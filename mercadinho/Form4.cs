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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("DATABASE=sistema_venda ; port=3306; SERVER=localhost; UID=root; pwd='' ");
                conexao.Open();

                MySqlCommand objcmd = new MySqlCommand("select nome, preco from produtos where id = ?", conexao);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("id", MySqlDbType.Int32).Value = txt_codigo2.Text;

                objcmd.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = objcmd.ExecuteReader();
                dr.Read();

                txt_nome2.Text = dr.GetString(0);
                txt_valor2.Text = dr.GetString(1);

             

                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível encontrar o produto");

                txt_codigo2.Clear();
                txt_nome2.Clear();
                txt_valor2.Clear();
                txt_codigo2.Focus();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection conexao = new MySqlConnection("DATABASE=sistema_venda ; port=3306; SERVER=localhost; UID=root; pwd='' ");
                
                conexao.Open();
                MySqlCommand objcmd = new MySqlCommand("insert into produtos (id, nome, preco) values (?, ?, ?)",conexao);

                objcmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txt_codigo2.Text;
                objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 20).Value = txt_nome2.Text;
                objcmd.Parameters.Add("@preco", MySqlDbType.Float, 10).Value = txt_valor2.Text;

                objcmd.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com sucesso !");
                txt_codigo2.Clear();
                txt_nome2.Clear();
                txt_valor2.Clear();
                txt_codigo2.Focus();

                conexao.Close();             
            }

            catch (Exception erro)
            {

                MessageBox.Show("Falha ao salvar ");
                

                txt_codigo2.Clear();
                txt_nome2.Clear();
                txt_valor2.Clear();
                txt_codigo2.Focus();

            }
        }

        private void btn_limpar2_Click(object sender, EventArgs e)
        {
            txt_codigo2.Clear();
            txt_nome2.Clear();
            txt_valor2.Clear();
            txt_codigo2.Focus();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("DATABASE=sistema_venda ; port=3306; SERVER=localhost; UID=root; pwd='' ");
                conexao.Open();

                MySqlCommand objcmd = new MySqlCommand("delete from produtos where id = ?", conexao);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txt_codigo2.Text;

                objcmd.CommandType = CommandType.Text;
                objcmd.ExecuteNonQuery();

                conexao.Close();
                MessageBox.Show("Produto deletado com sucesso !");
                txt_codigo2.Clear();
                txt_nome2.Clear();
                txt_valor2.Clear();
                txt_codigo2.Focus();

            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível deletar o produto !");
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("DATABASE=sistema_venda ; port=3306; SERVER=localhost; UID=root; pwd='' ");
                conexao.Open();

                MySqlCommand objcmd = new MySqlCommand("update produtos set nome = ?, preco = ? where id = ?", conexao);
                objcmd.Parameters.Clear();
                
                objcmd.Parameters.Add("@nome", MySqlDbType.VarChar, 20).Value = txt_nome2.Text;
                objcmd.Parameters.Add("@preco", MySqlDbType.Float, 10).Value = txt_valor2.Text;
                objcmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txt_codigo2.Text;

                objcmd.CommandType = CommandType.Text;
                objcmd.ExecuteNonQuery();


                conexao.Close();
                MessageBox.Show("Dados do produto atualizado com sucesso !");
                txt_codigo2.Clear();
                txt_nome2.Clear();
                txt_valor2.Clear();
                txt_codigo2.Focus();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível alterar os dados do produto");
                txt_codigo2.Clear();
                txt_nome2.Clear();
                txt_valor2.Clear();
                txt_codigo2.Focus();
            }
        }
    }
}
