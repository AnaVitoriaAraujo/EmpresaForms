using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa
{
    public partial class Excluir : Form
    {

        DAO exc;
        public Excluir()
        {
            exc = new DAO();
            InitializeComponent();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt64(cpf.Text), "pessoa");
            MessageBox.Show(result);
        }//botao excluir

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//cpf
    }//fim da classe
}//fim do projeto
