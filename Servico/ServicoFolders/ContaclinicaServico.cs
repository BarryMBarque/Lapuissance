using Modelo;
using Persistencia.RepositoryFolders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.ServicoFolders
{
    public class ContaclinicaServico
    {
        private Repositorio<ContaClinica> repositorio = new Repositorio<ContaClinica>();
        public void Gravar(ContaClinica contaclinica)
        {
            repositorio.Gravar(contaclinica);

        }
        public void Atualizar(ContaClinica contaclinica)
        {
            repositorio.Atualizar(contaclinica);

        }
        public IEnumerable<ContaClinica> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
    }
}
