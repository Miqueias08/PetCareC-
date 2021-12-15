using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetCareWork.DBConnection;
using System.Data;

namespace PetCareWork.Classes
{
    class ItensPedido
    {
        private int idPedido;
        private int idProduto;
        private int quantidade;
        private double desconto;

        public double Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public int IdProduto
        {
            get { return idProduto; }
            set { idProduto = value; }
        }

        public int IdPedido
        {
            get { return idPedido; }
            set { idPedido = value; }
        }

        public DataTableCollection Pesquisar(int idPed)
        {
            ConexaoMySQL banco = new ConexaoMySQL();
            string query = "SELECT ";
            query += "p.descricao, ip.quantidade, p.preco, ip.desconto,";
            query += "( ip.quantidade * p.preco) - ip.desconto AS Total ";
            query += " FROM itensPedido ip ";
            query += "INNER JOIN Produto p ON ip.idProduto = p.id ";
            query += "WHERE ip.idPEDIDO=" + idPed;
            return banco.Consulta(query);
        }
    }
}
