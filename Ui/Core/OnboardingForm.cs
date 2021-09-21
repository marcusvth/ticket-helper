using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework.Forms;
using tickethelper.Model;

namespace tickethelper
{
    internal partial class OnboardingForm : MetroForm
    {
        public OnboardingForm()
        {
            InitializeComponent();
        }

        public string Id
        {
            get => lbId.Text;
            set
            {
                lbId.Text = value;
                foreach (Control control in Controls)
                    if (control is Label)
                        control.Visible = !(value is null);

                pbUserNotFound.Visible = value is null;
            }
        }

        public string DisplayName
        {
            get => lbDisplayName.Text;
            set => lbDisplayName.Text = value ?? "—";
        }

        public string Title
        {
            get => lbTitle.Text;
            set => lbTitle.Text = value ?? "—";
        }

        public string Department
        {
            get => lbDepartment.Text;
            set => lbDepartment.Text = value ?? "—";
        }

        public string Company
        {
            get => lbCompany.Text;
            set => lbCompany.Text = value ?? "—";
        }

        public static void ShowInOnboardingPanel(User user)
        {
            MainUiForm.OnboardingForm.Id = user?.HeiwayAccount?.SamAccountName;
            if (user?.HeiwayAccount is null) return;
            MainUiForm.OnboardingForm.DisplayName = user.HeiwayAccount?.DisplayName;
            MainUiForm.OnboardingForm.Title = user.HeiwayAccount?.Title;
            MainUiForm.OnboardingForm.Department = user.HeiwayAccount?.Department;
            MainUiForm.OnboardingForm.Company = user.HeiwayAccount?.Company;
        }

        private void Labels_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(((Label) sender).Text);
        }

        private void OnboardingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}