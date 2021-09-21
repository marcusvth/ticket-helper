using System;
using System.Configuration;
using System.Windows.Forms;
using tickethelper.Service;
using System.IO;
using tickethelper.Ui;
using tickethelper.Ui.Core;
using tickethelper.View;
using System.Reflection;

namespace tickethelper
{
    internal static class Program
    {
        /// <summary>
        ///     Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            if (!File.Exists($"Config.config"))
            {
                MessageBox.Show($"Arquivo Config.config não encontrado. A aplicação será encerrada. \n\n Caso precise de uma cópia do arquivo, ela está localizada em \\\\server1\\upm$\\P00000", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Log.Add("============================ A aplicação está sendo inicializada ===========================", 1);
            Application.Run(new LoginForm());
        }
    }
}