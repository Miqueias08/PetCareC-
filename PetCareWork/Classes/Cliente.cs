using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PetCareWork.DBConnection;

namespace PetCareWork.Classes
{
    public class Cliente
    {
        private string nome;
        private string endereco;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private string cpf;
        private string telefone;
        private DateTime dataNasc;
        private string sexo;
        private string ID;

        public string ID1
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        ///////Métodos

        public DataTableCollection Pesquisar()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query = "SELECT * FROM Cliente ";//atenção ao espaço depois do usuario ";
            query += "WHERE nome LIKE '%" + this.Nome + "%';";
            return BANCO.Consulta(query);
        }

        

        public void Cadastro()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();
            string query;

            query = "INSERT INTO Cliente (nome,endereco,bairro,cidade,uf,cep,cpf,telefone,datanasc,sexo) values ";
            query += "('" + Nome + "','" + Endereco + "','" + Bairro + "','" + Cidade + "','" + Uf + "','" + Cep + "','" + Cpf + "','" + Telefone + "','" + DataNasc.ToString("yyyy-MM-dd") + "','" + Sexo + "');";

            Util.Mensagem(query); //isso mostra o que está sendo inserido no banco de dados
            BANCO.ExecutarComando(query);

        }



        public void Excluir()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query = "DELETE FROM cliente WHERE id =" + this.ID + ";";

            BANCO.ExecutarComando(query);
        }

        public void Atualizar()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query;

            query = "UPDATE cliente SET ";
            query += "nome='" + this.Nome + "', ";
            query += "endereco='" + this.Endereco + "', ";
            query += "bairro='" + this.Bairro + "', ";
            query += "cidade='" + this.Cidade + "', ";
            query += "uf='" + this.Uf + "', ";
            query += "cep='" + this.Cep + "', ";
            query += "cpf='" + this.Cpf + "', ";
            query += "telefone='" + this.Telefone + "', ";
            query += "datanasc='" + this.DataNasc.ToString("yyyy-MM-dd") + "', ";
            query += "sexo='" + this.Sexo + "' ";//tira a virgula antes do where
            query += "WHERE id =" + this.ID1 + ";";

            Util.Mensagem(query); // ajuda a verificar o erro 
            BANCO.ExecutarComando(query);
        }

        ////////Não mexidos ainda

        public void Buscar()//void nao tem retorno 
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query;

            query = "SELECT * FROM cliente WHERE id=" + this.ID + ";"; //atenção ao espaço depois do usuario ";
            DataTableCollection resultado = BANCO.Consulta(query);

            this.ID = resultado[0].Rows[0][0].ToString();
            this.Nome = Convert.ToString(resultado[0].Rows[0][1]);
            this.Telefone = Convert.ToString(resultado[0].Rows[0][2]);
            this.Cpf = Convert.ToString(resultado[0].Rows[0][3]);
            this.Endereco = Convert.ToString(resultado[0].Rows[0][4]);
            this.Bairro = Convert.ToString(resultado[0].Rows[0][5]);
            this.Cidade = Convert.ToString(resultado[0].Rows[0][6]);
            this.Uf = Convert.ToString(resultado[0].Rows[0][7]);
            this.Cep = Convert.ToString(resultado[0].Rows[0][8]);
            
            this.DataNasc = Convert.ToDateTime(resultado[0].Rows[0][9]);
            this.Sexo = Convert.ToString(resultado[0].Rows[0][10]);
        }
    }
}
