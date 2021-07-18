using Persistencia.DAO.POCO;
using System;
using System.Data;

namespace Persistencia.DAO.Repositorio
{
    public interface IRepositorio<Ttipo>
    {
        DataTable GetAll();
        Cliente GetById(int id);
        void Insert(Ttipo T);
        void Update(Ttipo T);
        void Delete(int id);
    }
}
