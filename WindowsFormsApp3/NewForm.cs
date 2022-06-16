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

        private void button2_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            autorisation.Show();
            this.Hide();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            StreamReader sr = new StreamReader(autorisation.path);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
