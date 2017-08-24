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
    public class UsuarioDAL
    {
        private ISession sessao = NHibernateHelper.AbrirSessao();

        public Usuario Adiciona(Usuario usuario)
        {
            ITransaction tx = sessao.BeginTransaction();
            sessao.SaveOrUpdate(usuario);
            tx.Commit();
            sessao.Close();
            return usuario;
        }
    }
}
