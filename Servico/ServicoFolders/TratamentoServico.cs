using Modelo;
using Persistencia.RepositoryFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.ServicoFolders
{
     public class TratamentoServico
    {
        private Repositorio<Tratamento> repositorio = new Repositorio<Tratamento>();
        public void Gravar(Tratamento tratamento)
        {
            repositorio.Gravar(tratamento);

        }
        public void Atualizar(Tratamento tratamento)
        {
            repositorio.Atualizar(tratamento);

        }
        public IEnumerable<Tratamento> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
        public IQueryable<Tratamento> Buscar(Func<Tratamento, bool> func)
        {
            return repositorio.Buscar(func);
        }
        public void Excluir(Func<Tratamento, bool> func)
        {

            repositorio.Excluir(func);
        }
    }
}
