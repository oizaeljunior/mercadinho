using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace mercadinho
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {



            try
            {

                MySqlConnection conexao = new MySqlConnection("DATABASE=sistema_venda ; port=3306; SERVER=localhost; UID=root; pwd='' ");
                conexao.Open();

                MessageBox.Show("Sucesso na Conexão !");
                Form1 OutroForm = new Form1();
                OutroForm.Show();
                this.Hide();
                
            }
            
            catch (Exception t)
            {

                MessageBox.Show("Falha na Conexão " + t);
                this.Hide();

            }





        }
    }
}
