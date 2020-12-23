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
        public Form1()
        {
            InitializeComponent();
            //this.Hide();
            this.ShowInTaskbar = false;
            Screen screen = new Screen();
            screen.Show();
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
    }
}
