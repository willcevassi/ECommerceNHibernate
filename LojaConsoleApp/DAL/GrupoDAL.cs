using LojaConsoleApp.Entidades;
using LojaConsoleApp.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaConsoleApp.DAL
{
    public class GrupoDAL
    {
        public Grupo Adiciona(Grupo grupo)
        {
            ISession session = NHibernateHelper.AbrirSessao();
            ITransaction tx = session.BeginTransaction();
            session.SaveOrUpdate(grupo);
            tx.Commit();
            session.Close();
            return grupo;
        }

        public Grupo get(int Id)
        {
            ISession session = NHibernateHelper.AbrirSessao();
            return (Grupo)session.Load<Grupo>(Id);
        }

        public Grupo get(int id, ISession session)
        {
            return session.Load<Grupo>(id);
        }

    }

}
