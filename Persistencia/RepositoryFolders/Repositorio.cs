using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Persistencia.RepositoryFolders
{
    public class Repositorio<T> : IDisposable, IRepositorio<T> where T : class 
    {
        private EFContext contexto;// = new EFContext();
        public IEnumerable<T> ObterTodos()
        {
            using (contexto = new EFContext())
            {
                return contexto.Set<T>().ToList();
            }
        }
        public IQueryable<T> Buscar(Func<T,bool> predicate)
        {
            using (contexto= new EFContext())
            {
                return ObterTodos().Where(predicate).AsQueryable();
            }
            
        }
      
        public void Gravar(T entidade)
        {
            using(contexto= new EFContext())
            {

                contexto.Set<T>().Add(entidade);
                this.SalvarMundancas();
            }
          

        }
        public void Atualizar(T entidade)
        {
        
            using (contexto = new EFContext())
            {
                contexto.Entry(entidade).State = EntityState.Modified;
                contexto.SaveChanges();
            }

        }

        public void Excluir(Func<T, bool> predicate)
        {  using(contexto= new EFContext())
            {
                contexto.Set<T>()
              .Where(predicate).ToList()
              .ForEach(del => contexto.Set<T>().Remove(del));
                contexto.SaveChanges(); 
            }
         
        }
        public void SalvarMundancas()
        {
             contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
