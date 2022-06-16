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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autorisation autorisation = new Autorisation();
            if (log.Text.Contains(" ") || pass.Text.Contains(" "))
            {
                MessageBox.Show("Нельзя использовать символ пробела!");
            }
            else
            {
                if (log.TextLength <= 3 || pass.TextLength <= 3)
                {
                    MessageBox.Show("Логин или пароль должен состоять из 4х или более символов!");
                    return;
                }
                else
                {
                    if (!File.Exists(autorisation.path))
                    {
                        File.AppendAllText(autorisation.path, $"{log.Text}:{pass.Text}\n");
                    }
                    else if (File.Exists(autorisation.path))
                    {
                        File.AppendAllText(autorisation.path, $"{log.Text}:{pass.Text}\n");
                    }
                    MessageBox.Show("Пользователь зарегистрирован!");
                }               
            }
            autorisation.Show();
            this.Hide();
        }

        private void Registr_Load(object sender, EventArgs e)
        {

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
    }
}
