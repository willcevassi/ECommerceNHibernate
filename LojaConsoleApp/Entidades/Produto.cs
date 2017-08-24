using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaConsoleApp.Entidades
{
    public class Produto
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual decimal Preco { get; set; }
        public virtual DateTime DataUltimaCompra { get; set; }
        public virtual Categoria Categoria { get; set; }


        public override string ToString()
        {
            return String.Format("[Id]:{0},[Nome]:{1},[Preco]:{2},[Categoria]:{3}", Id, Nome, Preco, Categoria.Nome);
        }

    }
}
