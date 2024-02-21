using Npgsql;
using System.Data;
using System.Windows.Forms;
using static DEMOPRACTICE_registr.DataBank;

namespace DEMOPRACTICE_registr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBank.SQLtoDB($"SELECT * FROM users WHERE login = '{textBox1.Text}'");
                string login = DataBank.dt.Rows[0][1].ToString();
                string password = DataBank.dt.Rows[0][2].ToString();
                if (login == textBox1.Text && password == textBox2.Text)
                {
                    DataBank.user_role = DataBank.dt.Rows[0][3].ToString();
                    DataBank.user_login = DataBank.dt.Rows[0][1].ToString();
                    this.Hide();
                    Form3 form3 = new Form3(this);
                    form3.ShowDialog();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                if (DataBank.wrong_counter == 3) 
                {
                    Form4 form4 = new Form4();
                    form4.ShowDialog();
                    this.Enabled = false;
                    textBox1.Enabled = false;
                    textBox1.ReadOnly = true;
                    textBox2.Enabled = false;
                    textBox2.ReadOnly = true;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    System.Threading.Thread.Sleep(2000);
                    this.Enabled = true;
                    textBox1.Enabled = true;
                    textBox1.ReadOnly = false;
                    textBox2.Enabled = true;
                    textBox2.ReadOnly = false;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    DataBank.wrong_counter = 1;
                }
                else
                {
                    DataBank.wrong_counter += 1;
                    MessageBox.Show("Ошибка. Проверьте введенные данные");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}