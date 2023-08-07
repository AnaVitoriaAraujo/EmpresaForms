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
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            NomeColunas();//nomear os titulos das colunas
            AdicionarDados();//preenchendo o datagrideview1
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";

        }

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false; // adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false; // deletar linhas
            dataGridView1.AllowUserToResizeColumns = false;//redimensionar colunas
            dataGridView1.AllowUserToResizeRows= false; //redimensionar linhas
            
            dataGridView1.ColumnCount = 5;
        }//fim do metodo

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do datagrid
        public void AdicionarDados()//so posso usar o datagrid na classe que foi criada
        {
            consul.PreencherVetor();//preencher os vetores

            for (int i = 0; i < consul.QuantidadeDados(); i++)
            {

                dataGridView1.Rows.Add(consul.CPF[i], consul.nome[i], consul.telefone[i], consul.cidade[i], consul.uf[i]);
                //adiciona dados no datagrid
            }//fim do for
            
        }//fim do adicionar

        private void label1_Click(object sender, EventArgs e)
        {

        }//titulo
    }//fim da classe
}//fim projeto
