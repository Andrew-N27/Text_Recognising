using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Recognising
{
    public partial class Form1 : Form
    {
        Form_Controle form_Controle = null;
        Screen Screen = null;

        static public string Language = "English";
        static public string GetLanguage() { return Language; }
        public Form1()
        {
            InitializeComponent();
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void showWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(form_Controle == null || form_Controle.IsDisposed)
            {
                form_Controle = new Form_Controle();
                form_Controle.Show();
            }
        }
        private void recognizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Screen == null || Screen.IsDisposed)
            {
                Screen = new Screen();
                Screen.ShowInTaskbar = false;
                Screen.Show();
            }
        }
        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            engTSMI.Checked = false;
            rusTSMI.Checked = false;
            ukrTSMI.Checked = false;

            ((ToolStripMenuItem)sender).Checked = true;
            Language = ((ToolStripMenuItem)sender).Text;
        }
        
    }
}
