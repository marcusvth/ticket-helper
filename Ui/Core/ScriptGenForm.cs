using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using tickethelper.Model;

namespace tickethelper.Ui.Core
{
    public partial class ScriptGenForm : MetroForm
    {
        private bool _shown;
        private readonly Dictionary<string, string> _directories = new Dictionary<string, string>
        {
            {"L:", "restrito$" },
            {"W:", "corporativo$" },
            {"M:", "fabricas2$" },
            {"T:", "home" }
        };

        private List<string> _scriptList = new List<string>();

        private readonly User _user;

        private readonly string[] _hosts =
            {@"server1", @"server1.host.com.br", @"192.168.0.1", @"192.168.0.2"};
        internal ScriptGenForm(User user)
        {
            _user = user;
            InitializeComponent();
            StartupConfig();
        }
        private void GenerateNewScript()
        {
            if (!_shown) return;
            _scriptList = GetMappingScripts();
            EnableControls();
            tbScript.Text = _scriptList[cbbScript.SelectedIndex];
        }

        private List<string> GetMappingScripts()
        {
            var account = rbHeiwayAccount.Checked
                ? $@"HEIWAY\{_user.HeiwayAccount.SamAccountName}"
                : $@"SCHINCARIOL\{_user.SchincariolAccount.SamAccountName}";


            var letter = cbbDirectory.SelectedItem.ToString();
            var folder = _directories[letter];
            var removeOldMapping = cbRemoveOldMapping.Checked ? $"net use {letter} /delete /y;" : null;

            var scriptList = cbPwd.Checked
                ? _hosts.Select(host => $@"net use {letter} \\{host}\{folder} /user:{account}").ToList()
                : _hosts.Select(host =>
                    $@"powershell {removeOldMapping} net use {letter} \\{host}\{folder} /user:{account}").ToList();
            var scriptPwdList = scriptList.Select(script => $"powershell {removeOldMapping} $pwd = Read-Host \"Digite sua senha para a conta {account} \"; {script} $pwd").ToList();

            return cbPwd.Checked ? scriptPwdList : scriptList;
        }

        private void EnableControls()
        {
            btnCopy.Enabled = true;
            tbScript.Enabled = true;
            cbbScript.Enabled = true;
        }

        private void StartupConfig()
        {
            cbbDirectory.SelectedIndex = 0;
            cbbScript.SelectedIndex = 0;
            _shown = true;
            rbSchinAccount.Enabled = _user.SchincariolAccount != null;
            rbHeiwayAccount.Enabled = _user.HeiwayAccount != null;
            rbHeiwayAccount.Checked = !rbSchinAccount.Enabled;
            GenerateNewScript();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbScript.Text);
        }
        private void All_CheckedChanged(object sender, EventArgs e)
        {
            GenerateNewScript();
        }

        private void CbbDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateNewScript();
        }
    }
}
