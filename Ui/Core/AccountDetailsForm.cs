using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Humanizer;
using MetroFramework.Forms;
using tickethelper.Model;
using tickethelper.Properties;
using tickethelper.Service.ActiveDirectory;

namespace tickethelper.Ui.Core
{
    internal partial class AccountDetailsForm : MetroForm
    {
        private readonly FriendlyUserAccount _account;
        private readonly AccountManager _accountManager;
        private readonly ToolTip _toolTip = new ToolTip();

        public AccountDetailsForm(FriendlyUserAccount account)
        {
            _account = account;
            InitializeComponent();
            EmployeeType = account.EmployeeType;
            Description = account.Description;
            O365License = account.ExtensionAttribute11;
            Info = account.Info;
            Groups = account.Groups.ToList();
            HasVpn = account.Groups.Contains("BR1-RASToken-US") &&
                     (account.Groups.Contains("BR1-RASHeineken-US") || account.Groups.Contains("BR1-RAS-IBM-US"));
            HasAzure = account.Groups.Contains("BR1-AzureAD-US");
            HasProxy = account.Groups.Contains("BR1-ProxyServiceStandard-US");
            _accountManager = new AccountManager(account);
            Text = $@"    Detalhes da conta {account.SamAccountName}";
        }

        public string O365License
        {
            set
            {
                _toolTip.SetToolTip(lbO365License, value ?? "Sem licença.");
                lbO365License.Tag = value;
                lbO365License.Text = value?.Truncate(53) ?? "Sem licença.";
            }
        }

        public string EmployeeType
        {
            set
            {
                lbEmployeeType.Tag = value;
                _toolTip.SetToolTip(lbEmployeeType, value ?? "Não definido.");
                lbEmployeeType.Text = value?.Truncate(53) ?? "Não definido.";
            }
        }

        public string Description
        {
            set
            {
                _toolTip.SetToolTip(lbDescription, value);
                lbDescription.Tag = value;
                lbDescription.Text = value?.Truncate(53) ?? "—";
            }
        }

        public string Info
        {
            set
            {
                _toolTip.SetToolTip(lbInfo, value);
                lbInfo.Tag = value;
                lbInfo.Text = value?.Truncate(53) ?? "—";
            }
        }

        public List<string> Groups
        {
            set => listGroups.DataSource = value;
        }

        public bool HasVpn
        {
            set => pbVpn.Image = value ? Resources.ok : Resources.notok;
        }

        public bool HasProxy
        {
            set => pbProxy.Image = value ? Resources.ok : Resources.notok;
        }

        public bool HasAzure
        {
            set => pbAzure.Image = value ? Resources.ok : Resources.notok;
        }

        private void CompactUiDetails_Shown(object sender, EventArgs e)
        {
            ControlLayout();
        }

        private void ControlLayout()
        {
            if (!_account.Path.Contains(EntryManager.SchincariolDomain)) return;
            lbGroupsHeader.Location = new Point(lbGroupsHeader.Location.X, lbDescription.Bottom + 10);
            listGroups.Location = new Point(listGroups.Location.X, lbGroupsHeader.Bottom + 10);
            Height = listGroups.Bottom + 40;
            Control[] controls =
                {lbInfo, lbInfoHeader, lbO365License, lbO365LicenseHeader, lbEmployeeType, lbEmployeeTypeHeader};
            foreach (var control in controls)
                control.Dispose();
            CenterToScreen();
        }

        private void CopySelectedGroupItem_Click(object sender, EventArgs e)
        {
            if (listGroups.SelectedItem is null) return;
            Clipboard.SetText(listGroups.SelectedItem.ToString());
        }

        private void CopyAllGroupsItem_Click(object sender, EventArgs e)
        {
            if (listGroups.SelectedItem is null) return;
            var groups = new StringBuilder();
            foreach (var group in listGroups.Items) groups.AppendLine(group.ToString());
            Clipboard.SetText(groups.ToString());
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {

            AddLicense();
            lbO365License.Text = "ENTERPRISEPACK|RMS_S_ENTERPRISE|OFFICESUBSCRIPTION|MCOSTANDARD".Truncate(53);
            MainUiForm.RefreshPage();
        }

        private void Labels_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((Label)sender).Tag?.ToString() ?? " ");
        }

        private void AddLicense()
        {
            var dialogResult = MessageBox.Show(this,
                $@"Deseja atribuir a licença padrão à conta {_account.SamAccountName}?",
                @"Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            _accountManager.AddLicense();
        }

    }
}