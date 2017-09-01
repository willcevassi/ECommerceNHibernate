using LojaConsoleApp.Entidades;
using LojaConsoleApp.Infra;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaConsoleApp.DAL
{
    public class UsuarioDAL
    {
        private ISession sessao;

        public UsuarioDAL(ISession sessao)
        {
            this.sessao = sessao;
        }

        public Usuario Adiciona(Usuario usuario)
        {
            ITransaction tx = sessao.BeginTransaction();
            sessao.SaveOrUpdate(usuario);
            tx.Commit();
            sessao.Close();
            return usuario;
        }

        public Usuario get(int Id)
        {
            ISession session = NHibernateHelper.AbrirSessao();
            return (Usuario)session.Load<Usuario>(Id);
        }


        public IList<UsuarioGrupo> getInfoGrupos(Usuario usuario)
        {
            return sessao.CreateCriteria<UsuarioGrupo>().Add(Expression.Eq("Id.Usuario.Id", usuario.Id)).List<UsuarioGrupo>();
        }

        protected internal virtual void AssociarGrupo(Usuario usr,Grupo grupo)
        {
            UsuarioGrupo ugrupo = new UsuarioGrupo();
            ugrupo.Id = new UsuarioGrupoId();
            ugrupo.Id.Usuario = usr;
            ugrupo.Id.Grupo = grupo;
            ugrupo.Ativo = true;
            sessao.SaveOrUpdate(ugrupo);
        }
    }
}
