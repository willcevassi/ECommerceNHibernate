using System;
using LojaConsoleApp.Entidades;
using LojaConsoleApp.Infra;
using NHibernate;

namespace LojaConsoleApp.DAL
{
    public  class CategoriaDAL

    {
      

        public Categoria Adiciona(Categoria categoria)
        {
            ISession session = NHibernateHelper.AbrirSessao();
            ITransaction tx = session.BeginTransaction();
            session.SaveOrUpdate(categoria);
            tx.Commit();
            session.Close();
            return categoria;
        }

        public Categoria getCategoria(int Id)
        {
            ISession session = NHibernateHelper.AbrirSessao();
            return (Categoria)session.Load<Categoria>(Id);
        }

        public Categoria GetCategoria(int id, ISession session)
        {
            return session.Load<Categoria>(id);
        }
    }
}