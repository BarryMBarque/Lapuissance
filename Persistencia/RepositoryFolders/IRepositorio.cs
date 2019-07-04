using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace Persistencia.RepositoryFolders
{
 
    
        public interface IRepositorio<T> where T : class
        {
           IEnumerable<T> ObterTodos();
           IQueryable<T> Buscar(Func<T, bool> predicate);
           void Gravar(T entidade);
           void Atualizar(T entidade);
           void Excluir(Func<T, bool> predicate);

            void SalvarMundancas();
        }
    
}
