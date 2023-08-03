using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Form1 : Form
    {

        Cadastrar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;

        public Form1()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }//label cadastro

        private void button1_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();

        }//butao cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
            
        }//butao atualizar

        private void button3_Click(object sender, EventArgs e)
        {
            con.ShowDialog();

        }//butao consultar

        private void button4_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }//botao excluir

        private void label2_Click(object sender, EventArgs e)
        {

        }//label CPF

        private void label3_Click(object sender, EventArgs e)
        {

        }//label nome



        private void label5_Click(object sender, EventArgs e)
        {

        }//label telefone

        private void label4_Click(object sender, EventArgs e)
        {

        }//label cidade

        private void label6_Click(object sender, EventArgs e)
        {

        }//label UF
    }//fim da classe
}//fim do projeto
