using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//fazer a conexao
using Renci.SshNet.Messages;

namespace Empresa
{
    internal class DAO
    {
        public MySqlConnection conexao; //conexao é a chave para cessar o banco de dados
        public long[] CPF;
        public string[] nome;
        public string[] telefone;
        public string[] cidade;
        public string[] uf;
        public int i;
        public int contador;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=EmpresaTI17T;Uid=root;password=");//parametro para acessar o banco de dados
            try
            {
                conexao.Open();//abrir a conexao com o banco de dados
                MessageBox.Show("Conectado");
            }catch(Exception erro) 
            {

                MessageBox.Show("Aldo deu errado!\n\n" + erro.Message);        
    
            }
            
        }//fim do contrutor

        //metodo de insercao
        public string Inserir(long CPF, string Nome, string Telefone, string Cidade, string UF, string nomeTabela)
        {

            string inserir = $"Insert into {nomeTabela}(CPF, Nome, Telefone, Cidade, UF) values('{CPF}', '{Nome}', '{Telefone}', '{Cidade}', '{UF}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);//pega o inseirir e coloca dentro do banco
            string resultado = sql.ExecuteNonQuery() + " Executado!";//ele que executa no banco pega o isenrir e da o control enter
            return resultado;

        }//fim do metodo

        public void PreencherVetor()
        {
            string query = "select * from pessoa";//comando que faz a seleção "query"

            //instanciar os vetores
            this.CPF = new long[100];
            this.nome = new string[100];
            this.telefone = new string[100];
            this.cidade = new string[100];
            this.uf = new string[100];

            //prepaar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);//executa dentro do banco de dados

            //leitor
            MySqlDataReader leitura = sql.ExecuteReader();//ele retorna 0 ou 1 se tiver dadoa 1 senao 0 e armazena no leitura pro vetor

            i = 0;
            contador = 0;
            while (leitura.Read())//enquanto for verdadeiro ele pega os dados do bando de dados
            {
                CPF[i] = Convert.ToInt64(leitura["CPF"]);//leitura é do sql que pega do banco e guarda aq
                nome[i] = leitura["Nome"] + "";
                telefone[i] = leitura["Telefone"] + "";
                cidade[i] = leitura["Cidade"] + "";
                uf[i] = leitura["UF"] + "";
                i++;
                contador++;
            }// fim do while

            //Encerro a comunicação com o banco de dados

            leitura.Close();

        }//fim preencher vetor

        public int QuantidadeDados()
        {
            return contador;
        }//fim do metodo

        public string Atualizar(long CPF, string nomeTabela, string campo, string dado)
        {
            string query = $"update pessoa {nomeTabela} set {campo} = '{dado}' where CPF = '{CPF}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado!";
            return resultado;
        }//fim do metodo

        public string Excluir(long CPF, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where CPF = {CPF}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluido!";
            return resultado;
        }//fim do metodo

    }//fim da clase
}//fim do projeto
