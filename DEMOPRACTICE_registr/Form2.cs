using Npgsql;
using static DEMOPRACTICE_registr.DataBank;

namespace DEMOPRACTICE_registr
{
    public partial class Form2 : Form
    {
        private Form1 f1;

        public Form2(Form1 f1)
        {
            InitializeComponent();
            this.f1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = "";
                DataBank.SQLtoDB($"SELECT EXISTS (SELECT true FROM users WHERE login = '{textBox1.Text}');");
                string a = DataBank.dt.Rows[0][0].ToString();
                if (DataBank.dt.Rows[0][0].ToString() == "True")
                {
                    throw new Exception("Логин занят");
                }
                else
                {
                    if (textBox2.Text.Length <= 8)
                    {
                        throw new Exception("Пароль слишком короткий");
                    }
                    else
                    {
                        if (DataBank.strContainsSymb(textBox2.Text, DataBank.password_symb) == true && DataBank.strContainsSymb(textBox2.Text, DataBank.password_str_lowercase) == true && DataBank.strContainsSymb(textBox2.Text, DataBank.password_str_uppercase))
                        {
                            DataBank.SQLtoDBwithChanges($"INSERT INTO users (login, password) VALUES ('{textBox1.Text}', '{textBox2.Text}');");
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Не все требования для пароля удовлетворены");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Show();
        }
    }
}