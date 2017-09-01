using System;
using LojaConsoleApp.Entidades;
using NHibernate;
using LojaConsoleApp.Infra;
using System.Collections;

namespace LojaConsoleApp.DAL
{
    public class ProdutoDAL
    {

        public Produto Adiciona(Produto produto)
        {
            ISession session = NHibernateHelper.AbrirSessao();
            ITransaction tx = session.BeginTransaction();
            session.SaveOrUpdate(produto);
            tx.Commit();
            session.Close();
            return produto;
        }

        
    }


}