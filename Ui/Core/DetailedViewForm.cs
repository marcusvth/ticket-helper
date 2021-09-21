using System;
using System.Collections.Generic;
using System.Drawing;
using MetroFramework.Forms;

namespace tickethelper.Ui
{
    public partial class DetailedViewForm : MetroForm
    {
        private readonly bool _namesMatch;
        private readonly bool _mailsMatch;
        private readonly bool _employeeIdMatch;
        public DetailedViewForm(bool namesMatch = true, bool mailsMatch = true, bool employeeIdMatch = true)
        {
            _namesMatch = namesMatch;
            _mailsMatch = mailsMatch;
            _employeeIdMatch = employeeIdMatch;
            InitializeComponent();
        }

        public List<object> DataSource { get; set; }

        private void AdvancedView_Shown(object sender, EventArgs e)
        {
            SuspendLayout();
            dgDetailed.DataSource = DataSource;
            dgDetailed.AutoResizeColumns();
            var normalColor = dgDetailed.Columns[0].DefaultCellStyle.BackColor;
            dgDetailed.Columns[0].DefaultCellStyle.BackColor = _employeeIdMatch ? normalColor : Color.DarkRed;
            dgDetailed.Columns[3].DefaultCellStyle.BackColor = dgDetailed.Columns[0].DefaultCellStyle.BackColor;
            dgDetailed.Columns[1].DefaultCellStyle.BackColor = _namesMatch ? normalColor : Color.DarkRed;
            dgDetailed.Columns[2].DefaultCellStyle.BackColor = _mailsMatch ? normalColor : Color.DarkRed;
            ResumeLayout();
        }
    }
}