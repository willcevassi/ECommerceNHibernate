using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaConsoleApp.Entidades
{
    public class Grupo
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }

       
    }
}
