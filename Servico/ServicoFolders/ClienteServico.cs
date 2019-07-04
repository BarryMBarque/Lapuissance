using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using Persistencia;
using Persistencia.RepositoryFolders;
using System.Data;


namespace Servico
{
   public class ClienteServico
    {
       
     
         private Repositorio<Cliente> repositorio = new Repositorio<Cliente>();
        public void Gravar(Cliente cliente)
        {
            repositorio.Gravar(cliente);

        }
        public void Atualizar(Cliente cliente)
        {
            repositorio.Atualizar(cliente);

        }
        public IEnumerable<Cliente> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
        public IQueryable<Cliente> Buscar(Func<Cliente, bool> func)
        {
            return repositorio.Buscar(func);
        }
        public void Excluir(Func<Cliente, bool> func)
        {

            repositorio.Excluir(func);
        }
          
    }
}
