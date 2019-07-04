using Modelo;
using Persistencia.RepositoryFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.ServicoFolders
{
    public class AtendimentoServico
    {
        private Repositorio<Atendimento> repositorio = new Repositorio<Atendimento>();
        public void Gravar(Atendimento atendimento )
        {
            repositorio.Gravar(atendimento);

        }
        public void Atualizar(Atendimento atendimento)
        {
            repositorio.Atualizar(atendimento);

        }
        public IEnumerable<Atendimento> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
        public IQueryable<Atendimento> Buscar(Func<Atendimento, bool> func)
        {
            return repositorio.Buscar(func);
        }
        public void Excluir(Func<Atendimento, bool> func)
        {

            repositorio.Excluir(func);
        }
    }

}

