using MetroFramework.Forms;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using tickethelper.Service;
using tickethelper.Service.ActiveDirectory;

namespace tickethelper.Ui.Core
{
    public partial class GestaoTelecomForm : MetroForm
    {
        private static Configuration config = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap {ExeConfigFilename = "Config.config"} , ConfigurationUserLevel.None);
        private string _employeeId;
        private bool _cancel;
        public GestaoTelecomForm(string employeeId)
        {
            _employeeId = employeeId;
            InitializeComponent();
        }

        private void Login()
        {
            var usernameField = webBrowser.Document.GetElementById("P101_USERNAME");
            var passwordField = webBrowser.Document.GetElementById("P101_PASSWORD");
            var loginButton = webBrowser.Document.GetElementsByTagName("button")[0];

            usernameField.InnerText = EntryManager.UserName;
            passwordField.InnerText = EntryManager.Password;
            loginButton.InvokeMember("Click");
 
        }

        private void Search()
        {
            var searchField = webBrowser.Document.GetElementById("R1671487558161820_search_field");
            var btnSearch = webBrowser.Document.GetElementById("R1671487558161820_search_button");
            var searchBy = webBrowser.Document.GetElementById("R1671487558161820_column_search_current_column");

            searchBy.SetAttribute("value", "MATRICULA");
            searchField.InnerText = _employeeId;
            btnSearch.InvokeMember("Click");
        }

        private async void Routine()
        {
            await Task.Delay(1000);
            webBrowser.Navigate(config.AppSettings.Settings["Key2"].Value);
            webBrowser.DocumentCompleted += (s, e) => {
                Login();
            };
            WaitLoading();
            if (_cancel) return;
            Search();   
        }
        private void GestaoTelecomForm_Load(object sender, System.EventArgs e)
        {
            try { Routine(); }
            catch { MessageBox.Show("O formulário não pôde ser carregado corretamente.", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void WaitLoading()
        {
            try
            {
                while (webBrowser.IsBusy || webBrowser.ReadyState != WebBrowserReadyState.Complete)
                {
                    Application.DoEvents();
                }
            }
            catch
            {
                _cancel = true;
            }
        }
    }
}
