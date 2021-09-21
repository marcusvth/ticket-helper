using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;
using MetroFramework.Forms;
using tickethelper.Controller;
using tickethelper.Properties;
using tickethelper.Service;
using tickethelper.Service.ActiveDirectory;
using tickethelper.Ui.View;

namespace tickethelper
{
    public partial class MainUiForm : MetroForm, IUiController
    {
        private const string UnlockSuccess = "Sim. Desbloqueio automático";
        private const string UnlockFail = "Sim. Falha ao desbloquear";
        private const uint EsContinuous = 0x80000000;
        private const uint EsSystemRequired = 0x00000001;
        private const uint EsDisplayRequired = 0x00000002;
        private ToolTip toolTip = new ToolTip();

        internal static OnboardingForm OnboardingForm = new OnboardingForm();

        private readonly Color _badColor = Color.OrangeRed;

        /* ------------------------ This form -------------------------- */

        private static MainUiController _controller;
        private readonly Color _goodColor = Color.PaleGreen;
        private readonly Color _vipColor = Color.FromArgb(255, 209, 71);

        /* ----------------------------- Events ----------------------------*/
        public MainUiForm()
        {
            InitializeComponent();
            _controller = new MainUiController(this);
            StartupRoutine();
        }

        public static NotifyIcon Notifier { get; private set; }

        public string KeyWord => tbSearch.Text;

        public bool CanForward
        {
            set => btnForward.Visible = value;
        }

        public bool CanBackward
        {
            set => btnBackward.Visible = value;
        }

        public bool CanAccessGestaoTelecom { set => btnGestaoTelecom.Visible = value; }

        public static void RefreshPage()
        {
            _controller.Refresh();
        }
        public List<object> DetailedDataSource
        {
            get => new List<object>();
            set => dgDetailed.DataSource = value;
        }

        public bool DetailedViewDocked => dockDetailedViewItem.Checked;

        /* ------------------------ User data ---------------------------*/
        public string DisplayName
        {
            get => lbDisplayName.Tag.ToString();
            set
            {
                lbDisplayName.Text = value?.Transform(To.TitleCase).Truncate(33) ?? "—";
                lbDisplayName.Tag = value ?? "—";
            }
        }

        public string Title
        {
            set => lbTitle.Text = value ?? "Cargo desconhecido";
        }

        public string Department
        {
            set => lbDepartment.Text = value ?? "Departamento desconhecido";
        }

        public string EmployeeId
        {
            set => lbEmployeeId.Text = value ?? "—";
        }
        public string GlobalId
        {
            set => lbGlobalId.Text = value ?? "—";
        }
        public string Mail
        {
            get => lbMail.Text;
            set => lbMail.Text = value ?? "—";
        }

        public string HeiwayId
        {
            get => lbHeiwayId.Text;
            set => lbHeiwayId.Text = value ?? "—";
        }

        public string OpCo
        {
            set => lbOpCo.Text = value ?? "—";
        }

        public bool IsVip
        {
            set
            {
                var headers = new Control[] { lbEmployeeIdHeader, lbGlobalIdHeader, lbMailHeader, lbOpCoHeader, lbHeiwayIdHeader, lbPhone1Header, lbPhone2Header };
                var controls = new Control[]
                    {lbDisplayName, lbEmployeeId, lbGlobalId, lbHeiwayId, lbMail, lbDepartment, lbTitle, lbOpCo, lbPhone1, lbPhone2};
                foreach (var control in controls)
                {
                    lbDisplayName.Image = value ? Resources.vip : null;
                    control.ForeColor = value ? _vipColor : Color.Honeydew;
                }

                foreach (var header in headers)
                {
                    header.Font = value
                        ? new Font(lbHeiwayIdHeader.Font, FontStyle.Bold)
                        : new Font(lbHeiwayIdHeader.Font, FontStyle.Regular);
                    header.ForeColor = value ? _vipColor : _goodColor;
                }
            }
        }

        public bool IsUserFound
        {
            set
            {
                pnlUser.Visible = value;
                pbUserNotFound.Visible = !value;
                btnScript.Visible = value;
                btnDetailedView.Visible = value;
            }
        }

        public bool NamesMatch { get; set; }

        public bool MailsMatch { get; set; }
        public string TelephoneNumber
        {
            get => lbPhone1.Text;
            set => lbPhone1.Text = value ?? "—";
        }
        public string Mobile
        {
            get => lbPhone2.Text;
            set => lbPhone2.Text = value ?? "—";
        }
        public bool EmployeeIdMatch { get; set; }

        /* ---------------------- Manager data -------------------------*/
        public string ManagerName
        {
            get => lbManagerName.Text;
            set => lbManagerName.Text = value ?? "—";
        }

        public string ManagerMail
        {
            set => lbManagerMail.Text = value ?? "—";
        }

        public string ManagerId
        {
            set => lbManagerId.Text = value ?? "—";
        }

        public bool IsManagerFound
        {
            set
            {
                Control[] mainControls =
                    {lbManagerName, lbManagerMail, lbManagerId, lbManagerIdHeader, lbManagerMailHeader};
                foreach (var control in mainControls) control.Visible = value;

                pbManagerNotFound.Visible = !value;
            }
        }

        /* ------------------------ HeiwayAccount ---------------------------*/
        public bool IsHeiwayAccountDisabled
        {
            set
            {
                btnToggleHeiway.Image = value ? Resources.switch_off : Resources.switch_on;
                btnToggleHeiway.Tag = value;
            }
        }

        public bool IsHeiDm
        {
            set => pbHeiDM.Visible = value;
        }

        public bool? IsHeiwayAutoUnlocked
        {
            set
            {
                switch (value)
                {
                    case true:
                        lbHeiwayIsLocked.Text = UnlockSuccess;
                        break;
                    case false:
                        lbHeiwayIsLocked.Text = UnlockFail;
                        break;
                    default:
                        lbHeiwayIsLocked.Text = "Não.";
                        break;
                }

                SetUnlockView(lbHeiwayIsLocked, lbHeiwayIsLockedHeader);
            }
        }

        public DateTime? HeiwayAccountExpireDate
        {
            set => lbHeiwayAccountExpire.Text =
                value is null
                    ? "Eterna"
                    : value?.ToShortDateString() + $@" ({value?.Humanize(culture: new CultureInfo("pt-BR"))})";
        }

        public bool IsHeiwayAccountExpired
        {
            set => lbHeiwayAccountExpireHeader.ForeColor = value ? _badColor : _goodColor;
        }

        public DateTime? HeiwayPwdExpireDate
        {
            set => lbHeiwayPwdExpire.Text =
                value is null
                    ? "Senha inicial"
                    : value?.ToShortDateString() + $@" ({value?.Humanize(culture: new CultureInfo("pt-BR"))})";
        }

        public bool IsHeiwayPwdExpired
        {
            set => lbHeiwayPwdExpireHeader.ForeColor = value ? _badColor : _goodColor;
        }

        public string HeiwayBadPwd
        {
            set => lbHeiwayBadPwd.Text = value;
        }

        public bool IsHeiwayAccountFound
        {
            set
            {
                pnlHeiway.Visible = value;
                pbHeiwayNotFound.Visible = !value;
            }
        }

        /* ------------------------ Schin ---------------------------*/
        public bool IsSchinAccountDisabled
        {
            set
            {
                btnToggleSchin.Tag = value;
                btnToggleSchin.Image = value ? Resources.switch_off : Resources.switch_on;
            }
        }

        public bool? IsSchinAutoUnlocked
        {
            set
            {
                switch (value)
                {
                    case true:
                        lbSchinIsLocked.Text = UnlockSuccess;
                        break;
                    case false:
                        lbSchinIsLocked.Text = UnlockFail;
                        break;
                    default:
                        lbSchinIsLocked.Text = "Não.";
                        break;
                }
                SetUnlockView(lbSchinIsLocked, lbSchinIsLockedHeader);
            }
        }

        public DateTime? SchinAccountExpireDate
        {
            set => lbSchinAccountExpire.Text =
                value is null
                    ? "Eterna"
                    : value?.ToShortDateString() + $@" ({value?.Humanize(culture: new CultureInfo("pt-BR"))})";
        }

        public bool IsSchinAccountExpired
        {
            set => lbSchinAccountExpireHeader.ForeColor = value ? _badColor : _goodColor;
        }

        public DateTime? SchinPwdExpireDate
        {
            set => lbSchinPwdExpire.Text =
                value is null
                    ? "Senha inicial"
                    : value?.ToShortDateString() + $@" ({value?.Humanize(culture: new CultureInfo("pt-BR"))})";
        }

        public bool IsSchinPwdExpired
        {
            set => lbSchinPwdExpireHeader.ForeColor = value ? _badColor : _goodColor;
        }

        public string SchinBadPwd
        {
            set => lbSchinBadPwd.Text = value;
        }


        public bool IsSchinAccountFound
        {
            set
            {
                pnlSchin.Visible = value;
                pbSchinNotFound.Visible = !value;
            }
        }

        private void StartupRoutine()
        {
            SetToolTips();
            Notifier = notifyIcon;
            FormClosed += delegate { notifyIcon = null; };
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            lbConnectedAs.Text = $@"Conectado como {EntryManager.UserName.ToUpper()}";
            tbSearch.Text = EntryManager.UserName;
            Search();
            NotificationService.Notify($"Bem vindo, {DisplayName.Replace("(ADM)", "").Trim()}", "Ticker Helper");
            SetThreadExecutionState(EsContinuous | EsSystemRequired | EsDisplayRequired);
        }

        [DllImport("kernel32.dll")]
        private static extern uint SetThreadExecutionState(uint esFlags);

        private void TbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || tbSearch.Text.Length < 4) return;
            Log.Add($"Entrada do usuário: {tbSearch.Text}", 1);
            Search();
        }

        private void BtnToggleHeiway_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ToggleHeiwayAccount();
        }

        private void BtnToggleSchin_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ToggleSchinAccount();

        }

        private void BtnResetHeiway_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ChangeHeiwayPassword();
        }

        private void BtnResetSchin_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ChangeSchinPassword();
        }
        private void SettingsItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void CloseItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyUserDataItem_Click(object sender, EventArgs e)
        {
            _controller.CopyUserData();
        }

        private void CopyManagerDataItem_Click(object sender, EventArgs e)
        {
            _controller.CopyManagerData();
        }

        private void SuspendLayouts()
        {
            pnlUser.SuspendLayout();
            pnlHeiway.SuspendLayout();
            pnlSchin.SuspendLayout();
            SuspendLayout();
        }

        private void ResumeLayouts()
        {
            pnlUser.ResumeLayout();
            pnlHeiway.ResumeLayout();
            pnlSchin.ResumeLayout();
            ResumeLayout();
        }

        private void Search()
        {
            SuspendLayouts();
            _controller.Search();
            tbSearch.Clear();
            ResumeLayouts();
        }

        private void BtnHeiwayMoreInfo_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ShowHeiwayDetails();
        }

        private void BtnSchinMoreInfo_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ShowSchinDetails();
        }

        private void LabelName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DisplayName);
        }

        private void Labels_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((Label)sender).Text);
        }

        private void SetUnlockView(Label label, Label header)
        {
            switch (label.Text)
            {
                case UnlockFail:
                    label.ForeColor = _badColor;
                    header.ForeColor = _badColor;
                    break;
                case UnlockSuccess:
                    label.ForeColor = Color.PaleGreen;
                    header.ForeColor = _goodColor;
                    break;
                default:
                    label.ForeColor = Color.Honeydew;
                    header.ForeColor = _goodColor;
                    break;
            }
        }

        private void ModernCompactUi_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnboardingForm.Dispose();
            Application.Exit();
        }

        private void OnboardingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnboardingForm.Visible = onboardingToolStripMenuItem.Checked;
            if (!OnboardingForm.Visible) CenterToParent();
            else Location = new Point(Location.X - OnboardingForm.Width / 2, Location.Y);
            OnboardingForm.SetDesktopLocation(Location.X + Size.Width, Location.Y);
        }

        private void PnlBorder_Move(object sender, EventArgs e)
        {
            OnboardingForm.SetDesktopLocation(Location.X + Size.Width, Location.Y);
        }

        private void ModernCompactUi_Shown(object sender, EventArgs e)
        {
            OnboardingForm.WindowState = WindowState;
        }

        private void CopyEnglishDataItem_Click(object sender, EventArgs e)
        {
            _controller.CopyEnglishUserData();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.Backward();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.Forward();
        }

        private void MainUiForm_Activated(object sender, EventArgs e)
        {
            if (!onboardingToolStripMenuItem.Checked) return;
            OnboardingForm.Visible = true;
            OnboardingForm.BringToFront();
            dgDetailed.Update();
        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ShowScriptsForUser();
        }

        private void dockDetailedViewItem_Click(object sender, EventArgs e)
        {
            if (dockDetailedViewItem.Checked)
                MessageBox.Show(
                    "Fixar a Visualização Detalhada mostrará as divergências (na cor vermelha) e resultados duplicados silenciosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Height = dockDetailedViewItem.Checked ? 664 : 475;
            CenterToScreen();
            dgDetailed.AutoResizeColumns();
        }

        private void SetToolTips()
        {
            toolTip.SetToolTip(btnDetailedView, "Mostrar visualização detalhada");
            toolTip.SetToolTip(btnScript, "Gerar scripts de mapeamento");
            toolTip.SetToolTip(btnBackward, "Voltar");
            toolTip.SetToolTip(btnForward, "Avançar");
            toolTip.SetToolTip(btnHeiwayMoreInfo, $"Mais informações desta conta");
            toolTip.SetToolTip(btnSchinMoreInfo, $"Mais informações desta conta");
            toolTip.SetToolTip(btnGestaoTelecom, $"Mostrar usuário no Gestão de Telecom");
            toolTip.SetToolTip(lbPhone2Header, "Clique para alterar o telefone do usuário");
        }

        private void btnDetailedView_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ShowDetailedView();
        }
        private void btnGestaoTelecom_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            _controller.ShowInGestaoTelecom();
        }

        private void DgDetailed_DataSourceChanged(object sender, EventArgs e)
        {
            SuspendLayout();
            if (dgDetailed.DataSource is null) return;
            var normalColor = dgDetailed.DefaultCellStyle.BackColor;
            dgDetailed.Columns[0].DefaultCellStyle.BackColor = EmployeeIdMatch ? normalColor : Color.DarkRed;
            dgDetailed.Columns[3].DefaultCellStyle.BackColor = dgDetailed.Columns[0].DefaultCellStyle.BackColor;
            dgDetailed.Columns[1].DefaultCellStyle.BackColor = NamesMatch ? normalColor : Color.DarkRed;
            dgDetailed.Columns[2].DefaultCellStyle.BackColor = MailsMatch ? normalColor : Color.DarkRed;
            dgDetailed.AutoResizeColumns();
            ResumeLayout();
        }

        private void LbPhone2Header_Click(object sender, EventArgs e)
        {
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            _controller.ChangePhone();
        }
    }
}