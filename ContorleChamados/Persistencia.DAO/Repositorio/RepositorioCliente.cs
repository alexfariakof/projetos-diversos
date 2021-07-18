using Persistencia.DAO.POCO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Persistencia.DAO.Repositorio
{
    public static class StringExtension
    {
        public static int ToInteger(this String strToConvert)
        {
            int strConvert;
            int.TryParse(strToConvert, out strConvert);
            return strConvert;
        }
    }

    public class RepositorioCliente : IRepositorio<Cliente>
    {

        public DataTable GetAll()
        {
            IDbCommand comando = DB.GetCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * From Cliente";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            
            return dt;
        }

        public Cliente GetById(int id)
        {
            IDbCommand comando = DB.GetCommand();
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new SqlParameter("@id", id));
            comando.CommandText = "Select * From Cliente Where idCliente = @id";

            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());

            Cliente cliente = new Cliente
            {
                Id = dt.Rows[0]["idCliente"].ToString().ToInteger(),
                Nome = dt.Rows[0]["nome"].ToString()
            };

            return cliente;
        }

        public void Insert(Cliente cliente)
        {
            IDbCommand comando = DB.GetCommand();
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new SqlParameter("@nome", cliente.Nome));
            comando.CommandText = "Insert Into Cliente (nome) Values (@nome)";

            comando.ExecuteNonQuery();
        }

        public void Update(Cliente cliente)
        {
            IDbCommand comando = DB.GetCommand();
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new SqlParameter("@id", cliente.Id));
            comando.Parameters.Add(new SqlParameter("@nome", cliente.Nome));
            comando.CommandText = "Update Cliente  set nome = @nome Where idCliente = @id ";

            comando.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            IDbCommand comando = DB.GetCommand();
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new SqlParameter("@id", id));
            comando.CommandText = "Delete From Cliente Where idCliente = @id";

            comando.ExecuteNonQuery();
        }

    }
}
