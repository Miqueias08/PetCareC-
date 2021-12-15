using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetCareWork.DBConnection;
using System.Data;

namespace PetCareWork.Classes
{
    public class Funcionario
    {

        private string NOME;
        private string TEL;
        private string CPF;
        private string CTPS;
        private string AGENCIA;
        private string CONTA;
        private string ENDER;
        private string BAIRRO;
        private string CIDADE;
        private string UF;
        private string CEP;
        private DateTime DTNsc;
        private string ID;

        public string ID1
        {
            get { return ID; }
            set { ID = value; }
        }

        public DateTime DTNsc1//isso pega a variável do txtDataNascimento do formulário
        {
            get { return DTNsc; }
            set { DTNsc = value; }
        }

        public string CEP1
        {
            get { return CEP; }
            set { CEP = value; }
        }

        public string UF1
        {
            get { return UF; }
            set { UF = value; }
        }

        public string CIDADE1
        {
            get { return CIDADE; }
            set { CIDADE = value; }
        }

        public string BAIRRO1
        {
            get { return BAIRRO; }
            set { BAIRRO = value; }
        }

        public string ENDER1
        {
            get { return ENDER; }
            set { ENDER = value; }
        }

        public string CONTA1
        {
            get { return CONTA; }
            set { CONTA = value; }
        }

        public string AGENCIA1
        {
            get { return AGENCIA; }
            set { AGENCIA = value; }
        }

        public string CTPS1
        {
            get { return CTPS; }
            set { CTPS = value; }
        }

        public string CPF1
        {
            get { return CPF; }
            set { CPF = value; }
        }

        public string TEL1
        {
            get { return TEL; }
            set { TEL = value; }
        }

        public string NOME1
        {
            get { return NOME; }
            set { NOME = value; }
        }


        ///////Métodos

        public void Cadastro()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();
            string query;

            query = "INSERT INTO funcionario (nome,telefone,cpf,ctps,agencia,ccorrente,endereco,bairro,cidade,uf,cep,datanasc) values ";
            query += "('" + NOME1 + "','" + TEL1 + "','" + CPF1 + "','" + CTPS1 + "','" + AGENCIA1 + "','" + CONTA1 + "','" + ENDER1 + "','" + BAIRRO1 + "','" + CIDADE1 + "','" + UF1 + "','" + CEP1 + "','" + DTNsc1.ToString("yyyy-MM-dd") + "');";

            // Util.Mensagem(query); isso mostra o que está sendo inserido no banco de dados
            BANCO.ExecutarComando(query);

        }



        public void Excluir()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query = "DELETE FROM funcionario WHERE id =" + this.ID + ";";

            BANCO.ExecutarComando(query);
        }

        public void Atualizar()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query;

            query = "UPDATE funcionario SET ";
            query += "nome='" + this.NOME1 + "', ";//atenção aos espaços da quebra de linha ";
            query += "telefone='" + this.TEL1 + "', ";
            query += "cpf='" + this.CPF1 + "', ";
            query += "CTPS='" + this.CTPS1 + "', ";
            query += "agencia='" + this.AGENCIA1 + "', ";
            query += "ccorrente='" + this.CONTA1 + "', ";
            query += "endereco='" + this.ENDER1 + "', ";
            query += "bairro='" + this.BAIRRO1 + "', ";
            query += "cidade='" + this.CIDADE1 + "', ";
            query += "uf='" + this.UF1 + "', ";
            query += "cep='" + this.CEP1 + "', ";
            query += "datanasc='" + this.DTNsc1.ToString("yyyy-MM-dd") + "' ";//tira a virgula antes do where
            query += "WHERE id =" + this.ID1 + ";";



            //Util.Mensagem(query);  ajuda a verificar o erro 
            BANCO.ExecutarComando(query);
        }

        ////////Não mexidos ainda

        public void Buscar()//void nao tem retorno 
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query;

            query = "SELECT * FROM funcionario WHERE id=" + this.ID + ";"; //atenção ao espaço depois do usuario ";
            DataTableCollection resultado = BANCO.Consulta(query);

            this.ID = resultado[0].Rows[0][0].ToString();
            this.NOME = Convert.ToString(resultado[0].Rows[0][1]);
            this.TEL = Convert.ToString(resultado[0].Rows[0][2]);
            this.CPF = Convert.ToString(resultado[0].Rows[0][3]);
            this.CTPS = Convert.ToString(resultado[0].Rows[0][4]);
            this.AGENCIA = Convert.ToString(resultado[0].Rows[0][5]);
            this.CONTA = Convert.ToString(resultado[0].Rows[0][6]);

            this.ENDER = Convert.ToString(resultado[0].Rows[0][7]);
            this.BAIRRO = Convert.ToString(resultado[0].Rows[0][8]);
            this.CIDADE = Convert.ToString(resultado[0].Rows[0][9]);
            this.UF = Convert.ToString(resultado[0].Rows[0][10]);
            this.CEP = Convert.ToString(resultado[0].Rows[0][11]);
            this.DTNsc = Convert.ToDateTime(resultado[0].Rows[0][12]);

        }

        public DataTableCollection Pesquisar()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query = "SELECT * FROM funcionario ";//atenção ao espaço depois do usuario ";
            query += "WHERE nome LIKE '%" + this.NOME1 + "%';";
            return BANCO.Consulta(query);
        }
    }
}
