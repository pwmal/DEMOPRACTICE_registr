using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMOPRACTICE_registr
{
    public partial class Form3 : Form
    {
        private Form1 f1;

        public Form3(Form1 f1)
        {
            InitializeComponent();
            label3.Text = DataBank.user_login;
            DataBank.SQLtoDB("SELECT * FROM products ORDER BY id ASC");
            dataGridView1.DataSource = DataBank.dt;
            this.f1 = f1;
            if (DataBank.user_role == "admin")
            {
                this.BackColor = Color.Red;
            }
            if (DataBank.user_role == "manager")
            {
                this.BackColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dataGridstr = "";
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        dataGridstr += (dataGridView1.Rows[i].Cells[j].Value + "     ");
                    }
                    dataGridstr += Environment.NewLine;
                }
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "All text files|*.txt";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(SFD.FileName, dataGridstr);
                }
                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string dataGridstr = "";
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                    {
                        dataGridstr += (dataGridView1.Rows[i].Cells[j].Value + ";");
                    }
                    dataGridstr += Environment.NewLine;
                }
                SaveFileDialog SFD = new SaveFileDialog();
                SFD.Filter = "Table files|*.csv";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(SFD.FileName, dataGridstr);
                }
                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Close();
        }
    }
}
