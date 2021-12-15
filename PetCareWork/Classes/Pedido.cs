using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetCareWork.DBConnection;
using System.Data;

namespace PetCareWork.Classes
{
    public class Pedido
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private DateTime dataPedido;

        public DateTime DataPedido
        {
            get { return dataPedido; }
            set { dataPedido = value; }
        }
        private double frete;

        public double Frete
        {
            get { return frete; }
            set { frete = value; }
        }
        private int idcliente;

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private int idFuncionario;

        public int IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }

        public DataTableCollection Pesquisar(int idCli)
        {
            ConexaoMySQL banco = new ConexaoMySQL();
            string query = "SELECT * from pedido WHERE idCliente =" + idCli;
            return banco.Consulta(query);
        }
    }
}
