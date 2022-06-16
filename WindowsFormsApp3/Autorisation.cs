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

    public partial class Autorisation : Form
    {
        public string path = Directory.GetCurrentDirectory() + "\\LogPass.txt";

        public int count = 3;
        public Autorisation()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            log.UseSystemPasswordChar = true;
            pass.UseSystemPasswordChar = true;
            button3.Visible = false;
            label4.Text = "Осталось попыток: 3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Show();
            this.Hide();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            if (log.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Нельзя оставлять поле пустым!");
            }

            foreach (string line in File.ReadLines(path))
            {
                if(line == log.Text + ":" + pass.Text)
                {
                    NewForm newForm = new NewForm();
                    newForm.Show();
                    this.Hide();
                }
            }
            count -= 1;
            if (count == 0)
            {
                MessageBox.Show("Превышен лимит попыток");
                Application.Exit();
            }
            label4.Text = $"Осталось попыток: {count}";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            log.UseSystemPasswordChar = true;
            pass.UseSystemPasswordChar = true;
            button4.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            log.UseSystemPasswordChar = false;
            pass.UseSystemPasswordChar = false;
            button4.Visible = false;
            button3.Visible = true;
        }

        private void Autorisation_Load(object sender, EventArgs e)
        {

        }
    }
}
