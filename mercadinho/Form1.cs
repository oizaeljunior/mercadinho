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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        

        private void Btn_produtos_Click(object sender, EventArgs e)
        {
            Form4 OutroForm = new Form4();
            OutroForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("DATABASE=sistema_venda ; port=3306; SERVER=localhost; UID=root; pwd='' ");
                conexao.Open();

                MySqlCommand objcmd = new MySqlCommand("select nome, preco from produtos where id = ?", conexao);
                objcmd.Parameters.Clear();
                objcmd.Parameters.Add("@id", MySqlDbType.Int32).Value = txt_codigo.Text;               
                
                objcmd.CommandType = CommandType.Text;

                MySqlDataReader dr;
                dr = objcmd.ExecuteReader();
                dr.Read();

                txt_nome.Text = dr.GetString(0);
                lbl_valor.Text = dr.GetString(1);

                conexao.Close();

                txt_nome.Visible = true;
                txt_quantidade.Visible = true;
                lbl_valor.Visible = true;
                lbl_total.Visible = true;
                txt_dinheiro.Visible = true;
                txt_cartao.Visible = true;
                lbl_total2.Visible = true;
                lbl_troco.Visible = true;
                txt_quantidade.Focus();
                label12.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label14.Visible = false;    
                label15.Visible = false;    
                label16.Visible = false;    
                label17.Visible = false;
                label18.Visible = false;    
                
            }

            catch(Exception erro)
            {
                MessageBox.Show("Erro ao buscar o produto");
                txt_codigo.Clear();
                txt_nome.Clear();
                txt_quantidade.Clear();
                lbl_valor.Text = "";
                lbl_total.Text = "";
                txt_dinheiro.Clear();
                txt_cartao.Clear();
                lbl_total2.Text = "";
                lbl_troco.Text = "";
                txt_codigo.Focus();
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "" && txt_nome.Text != "" && txt_quantidade.Text != "" && lbl_valor.Text != "" && lbl_total.Text != "" && txt_dinheiro.Text != "" && txt_cartao.Text != "" && lbl_total2.Text != "" && lbl_troco.Text != "")
            {
                double total, total2;

                total = double.Parse(lbl_total.Text);
                total2 = double.Parse(lbl_total2.Text);

                lbl_total.Text = total.ToString();
                lbl_total2.Text = total2.ToString();

                if(total2 >= total)
                {


                    MessageBox.Show("Venda concluída com sucesso !");
                    txt_codigo.Clear();
                    txt_nome.Clear();
                    txt_quantidade.Clear();
                    lbl_valor.Text = "";
                    lbl_total.Text = "";
                    txt_dinheiro.Clear();
                    txt_cartao.Clear();
                    lbl_total2.Text = "";
                    lbl_troco.Text = "";
                    txt_codigo.Focus();
                    label12.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    txt_nome.Visible = false;
                    txt_quantidade.Visible = false;
                    lbl_valor.Visible = false;
                    lbl_total.Visible = false;
                    txt_dinheiro.Visible = false;
                    txt_cartao.Visible = false;
                    lbl_total2.Visible = false;
                    lbl_troco.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Não foi possível finalizar a venda !");
            }
                

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VENDA CANCELADA !");

            txt_codigo.Clear();
            txt_nome.Clear();
            txt_quantidade.Clear();
            lbl_valor.Text = "";
            lbl_total.Text = "";
            txt_dinheiro.Clear();
            txt_cartao.Clear();
            lbl_total2.Text = "";
            lbl_troco.Text = "";
            txt_codigo.Focus();
            label12.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            txt_nome.Visible = false;
            txt_quantidade.Visible = false;
            lbl_valor.Visible = false;
            lbl_total.Visible = false;
            txt_dinheiro.Visible = false;
            txt_cartao.Visible = false;
            lbl_total2.Visible = false;
            lbl_troco.Visible = false;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_quantidade.Clear();
            lbl_valor.Text = "";
            lbl_total.Text = "";
            txt_dinheiro.Clear();
            txt_cartao.Clear(); ;
            lbl_total2.Text = "";
            lbl_troco.Text = "";
            txt_codigo.Focus();
            label12.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            txt_nome.Visible = false;
            txt_quantidade.Visible = false;
            lbl_valor.Visible = false;
            lbl_total.Visible = false;
            txt_dinheiro.Visible = false;
            txt_cartao.Visible = false;
            lbl_total2.Visible = false;
            lbl_troco.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            txt_nome.Visible = false;
            txt_quantidade.Visible = false;
            lbl_valor.Visible = false;  
            lbl_total.Visible = false;
            txt_dinheiro.Visible = false;
            txt_cartao.Visible = false;
            lbl_total2.Visible = false;
            lbl_troco.Visible = false;
            txt_codigo.Focus();
        }


        void Soma()
        {
            double quant = 0, valor = 0, total = 0;

            if (txt_quantidade.Text != "" && lbl_valor.Text != "")
            {
                quant = double.Parse(txt_quantidade.Text);
                valor = double.Parse(lbl_valor.Text);

                total = quant * valor;
            }
            lbl_total.Text = total.ToString();
        }



        void Soma1()
        {
            double din = 0, cartao = 0, total2 = 0;

            if (txt_dinheiro.Text != "" && txt_cartao.Text != "")
            {
                din = double.Parse(txt_dinheiro.Text);
                cartao = double.Parse(txt_cartao.Text);

                total2 = din + cartao;
            }
            lbl_total2.Text = total2.ToString();
        }



        void Troco()
        {
            double troco = 0, total = 0, total2 = 0;

            if (lbl_total.Text != "" && lbl_total2.Text != "")
            {
                total = double.Parse(lbl_total.Text);
                total2 = double.Parse(lbl_total2.Text);

                if (total2 > total)
                {
                    troco = total2 - total;
                }
            }
            lbl_troco.Text = troco.ToString();
            
        }


        private void txt_quantidade_TextChanged(object sender, EventArgs e)
        {
            Soma();
        }

        private void txt_cartao_TextChanged(object sender, EventArgs e)
        {
           
            Soma1();
            Troco();
        }

        private void txt_dinheiro_TextChanged(object sender, EventArgs e)
        {
            Troco();
            Soma1();
        }

        private void lbl_troco_Click(object sender, EventArgs e)
        {
            Troco();
        }
    }
}
