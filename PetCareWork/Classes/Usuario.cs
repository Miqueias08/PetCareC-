using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PetCareWork.DBConnection;

namespace PetCareWork.Classes
{
    public class Usuario
    {

        private int id;
        private int tipo;
        private string login;
        private string senha;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        //metodo validar login

        public bool ValidaLogin()
        {

            ConexaoMySQL banco = new ConexaoMySQL();
            string query;
            query = "SELECT * from usuario WHERE login='" + this.login + "'AND senha='" + this.senha + "';";

            //rodar a query

            try //tab tab
            {
                DataTableCollection resultado = banco.Consulta(query);

                if (resultado[0].Rows.Count > 0)
                {

                    this.tipo = Convert.ToInt32(resultado[0].Rows[0][3]);//0=linha  3=coluna
                    return true;
                }


            }
            catch (Exception ERRO)
            {

                throw new Exception("Erro durante a pesquisa de usuário: " + ERRO.Message); //lança no form
            }
            return false;
        }

        public void Cadastro()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();
            string query;
            query = "insert into usuario(login,senha,tipo) values ";
            query += "('" + login + "','" + senha + "'," + tipo + ");";
            BANCO.ExecutarComando(query);
        }

        public void Excluir()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query = "DELETE FROM usuario WHERE id=" + this.id + ";";

            BANCO.ExecutarComando(query);
        }

        public DataTableCollection Pesquisar()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query = "SELECT id AS 'Código',login,tipo FROM usuario ";//atenção ao espaço depois do usuario ";
            query += "WHERE login LIKE '%" + this.login + "%';";

            return BANCO.Consulta(query);


        }

        public void Atualizar()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query;

            query = "UPDATE usuario SET ";
            query += "login='" + this.login + "', ";//atenção ao espaços da quebra de linha ";
            query += "senha='" + this.senha + "', ";
            query += "tipo='" + this.tipo + "' ";
            query += "WHERE id =" + this.id + ";";
            //Util.Mensagem(query);  ajuda a verificar o erro 
            BANCO.ExecutarComando(query);
        }

        public void Buscar()//void nao tem retorno 
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query;

            query = "SELECT * FROM usuario WHERE id=" + this.id + ";"; //atenção ao espaço depois do usuario ";
            DataTableCollection resultado = BANCO.Consulta(query);

            this.id = Convert.ToInt32(resultado[0].Rows[0][0]);
            this.login = Convert.ToString(resultado[0].Rows[0][1]);
            this.senha = " ";
            this.tipo = Convert.ToInt32(resultado[0].Rows[0][3]);

        }
    }
}
