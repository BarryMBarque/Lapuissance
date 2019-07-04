using Modelo;
using Persistencia.RepositoryFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.ServicoFolders
{
     public class FuncionarioServico
    {

        private Repositorio<Funcionario> repositorio = new Repositorio<Funcionario>();
        public void Gravar(Funcionario funcionario)
        {
            repositorio.Gravar(funcionario);

        }
        public void Atualizar(Funcionario funcionario)
        {
            repositorio.Atualizar(funcionario);

        }
        public IEnumerable<Funcionario> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
        public IQueryable<Funcionario> Buscar(Func<Funcionario, bool> func)
        {
            return repositorio.Buscar(func);
        }
        public void Excluir(Func<Funcionario, bool> func)
        {

            repositorio.Excluir(func);
        }
    }
}
