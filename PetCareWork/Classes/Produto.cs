using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using PetCareWork.DBConnection;

namespace PetCareWork.Classes
{
    public class Produto
    {
        private int ID;
        private string TIPO;
        private string NOME;
        private string PARA;
        private string MARCA;
        private string UNIT;
        private string PESO;
        private string CNPJ;
        private string FABRIC;
        private string VALID;
        private string DTCOMP;
        private string CUSTO;
        private string LOTE;
        private string CADASTRANTE;
        private string DTCADPROD;

        public int ID1
        {
            get { return ID; }
            set { ID = value; }
        }

        public string DTCADPROD1
        {
            get { return DTCADPROD; }
            set { DTCADPROD = value; }
        }

        public string CADASTRANTE1
        {
            get { return CADASTRANTE; }
            set { CADASTRANTE = value; }
        }

        public string LOTE1
        {
            get { return LOTE; }
            set { LOTE = value; }
        }

        public string CUSTO1
        {
            get { return CUSTO; }
            set { CUSTO = value; }
        }

        public string DTCOMP1
        {
            get { return DTCOMP; }
            set { DTCOMP = value; }
        }

        public string VALID1
        {
            get { return VALID; }
            set { VALID = value; }
        }

        public string FABRIC1
        {
            get { return FABRIC; }
            set { FABRIC = value; }
        }

        public string CNPJ1
        {
            get { return CNPJ; }
            set { CNPJ = value; }
        }

        public string PESO1
        {
            get { return PESO; }
            set { PESO = value; }
        }

        public string UNIT1
        {
            get { return UNIT; }
            set { UNIT = value; }
        }

        public string MARCA1
        {
            get { return MARCA; }
            set { MARCA = value; }
        }

        public string PARA1
        {
            get { return PARA; }
            set { PARA = value; }
        }
        public string NOME1
        {
            get { return NOME; }
            set { NOME = value; }
        }

        public string TIPO1
        {
            get { return TIPO; }
            set { TIPO = value; }
        }


        private string OptionProd;

        public string OptionProd1
        {
            get { return OptionProd; }
            set { OptionProd = value; }
        }
            
      

        //Metodo
        

        public DataTableCollection Pesquisar()
        {
            ConexaoMySQL banco = new ConexaoMySQL();
            string query = "select * FROM produto ";
            query += "WHERE nome LIKE '%" + this.NOME1+ "%';";
            return banco.Consulta(query);
        }
        
        public void GravarProd()
        {
            ConexaoMySQL banco = new ConexaoMySQL();
            string query;
            // query += "('" + Prodnome + "'," + valor + ");";

            query = "INSERT INTO produto (TIPO,PARA,NOME,MARCA,UNIT,PESO,CNPJ,FABRIC,VALIDADE,DTCOMP,CUSTO,LOTE,CADASTRANTE,DTPRODCAD) VALUES ";
            query += "('" + TIPO1 + "','" + PARA1 + "','" + NOME1 + "','" + MARCA1 + "','" + UNIT1 + "','" + PESO1 + "','" + CNPJ1 + "','" + FABRIC1 + "','" + VALID1 + "','" + DTCOMP1 + "','" + CUSTO1 + "','" + LOTE1 + "','" + CADASTRANTE1 + "','" + DTCADPROD1 + "');";

            banco.ExecutarComando(query);
        }

        public void Excluir()
        {
            ConexaoMySQL BANCO = new ConexaoMySQL();

            string query = "DELETE FROM produto WHERE id = " + this.ID + ";";

            BANCO.ExecutarComando(query);
        }
    }
}
