using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//chamando o my sql

namespace Empresa
{
    public partial class Cadastrar : Form
    {

        DAO conectar;
        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();//ligando o formulario conectar
        }//fim contrutor

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim telefone

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//botao uf

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = conectar.Inserir(Convert.ToInt64(cpf.Text), nome.Text,
               telefone.Text, cidade.Text, uf.Text, "pessoa");

                MessageBox.Show(result);

            }catch (Exception erro) 
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }            
           
        }//fim do botao inserir

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//fim nome

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//fim cidade
    }//fim da classe
}//fim do prjeto
