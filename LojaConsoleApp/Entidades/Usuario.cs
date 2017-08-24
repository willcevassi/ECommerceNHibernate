using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaConsoleApp.Entidades
{
    public class Usuario
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }



        public override string ToString()

        {
            return String.Format("[ID]:{0},[Nome]:{1}", Id, Nome);
        }


    }



}
