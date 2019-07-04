using Modelo;
using Persistencia.RepositoryFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.ServicoFolders
{
     public class MedicoServico
    {
        private Repositorio<Medico> repositorio = new Repositorio<Medico>();
        public void Gravar(Medico medico)
        {
            repositorio.Gravar(medico);

        }
        public void Atualizar(Medico medico)
        {
            repositorio.Atualizar(medico);

        }
        public IEnumerable<Medico> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
        public IQueryable<Medico> Buscar(Func<Medico, bool> func)
        {
            return repositorio.Buscar(func);
        }
    }
}
