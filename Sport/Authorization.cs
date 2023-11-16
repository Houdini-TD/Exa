using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport
{
    public partial class Authorization : Form
    {
        string captchaAnswer = "none";
        public Authorization()
        {
            InitializeComponent();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {
            if(tbLogin.Text != "" && tbPassword.Text != "" && captchaAnswer == "none")
            {
                btnEnter.Enabled = true;
            }
            else
            {
                btnEnter.Enabled = false;
            }
        }

        private void generateCaptcha()
        {
            lbC1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Strikeout);
            lbC2.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Strikeout);
            Random random = new Random();
            int a = random.Next(10, 100);
            int b = random.Next(10,100);
            lbC1.Text = a.ToString();
            lbC2.Text = b.ToString();

            lbC1.Visible = true;
            lbC2.Visible = true;
            tbCaptcha.Visible = true;
            captchaAnswer = a.ToString() + b.ToString();
        }

        private void dropCaptcha()
        {
            captchaAnswer = "none";
            lbC1.Visible = false;
            tbCaptcha.Visible = false;
        }

        private void tbCaptcha_Click(object sender, EventArgs e)
        {
            generateCaptcha();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string query = $"select  UserPassword, UserRole from [User] where UserLogin = '{login}'";
            var reader = SQL.ExecuteReader(query);

            if (reader.Read())
            {
                if (reader.GetString(0) == tbPassword.Text)
                {
                    ProductChoose productChoose = new ProductChoose();
                    productChoose.ShowDialog();

                }
            }
            else
            {
                MessageBox.Show("Неправильный пароль");
                generateCaptcha();
            }   
        }
    }
}
