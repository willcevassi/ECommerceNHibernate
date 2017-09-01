using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaConsoleApp.Entidades
{
    public class UsuarioGrupoId
    {
        public virtual Usuario Usuario { get; set; }
        public virtual Grupo Grupo { get; set; }

  
    public override bool Equals(Object obj)
        {

            UsuarioGrupoId comparador = new UsuarioGrupoId();
            UsuarioGrupoId original = (UsuarioGrupoId)obj;

            return (original.Grupo.Equals(comparador.Grupo)) && (original.Usuario.Equals(comparador.Usuario));
        }

        public override int GetHashCode()
        {
            return Usuario.Id.GetHashCode() + Grupo.Id.GetHashCode();
        }

    }

    
}
