using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class NewForm : Form
    {
        public NewForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти из программы, при этом потеряв все данные?", "Завершение программы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Application.Exit();
            Autorisation autorisation = new Autorisation();
            using (FileStream fs = new FileStream(autorisation.path, FileMode.Open, FileAccess.ReadWrite))
            {
                fs.SetLength(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            autorisation.Show();
            this.Hide();
        }
    }
}
