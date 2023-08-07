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
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            atu = new DAO();
            InitializeComponent();
        }//fim do contrutor

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "nome", nome.Text);//atualizo o nome 
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "telefone", telefone.Text);//atualizo o nome 
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "cidade", cidade.Text);//atualizo o nome 
            atu.Atualizar(Convert.ToInt64(cpf.Text), "pessoa", "UF", uf.Text);//atualizo o nome 
            MessageBox.Show("Dados Atualizar com sucesso! ");
        }//fim botao atualizar

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do cpf

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//fim do nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//fim do cidade

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim do uf
    }//fim da classe
}//fim do projeto
