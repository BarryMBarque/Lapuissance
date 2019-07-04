using Modelo;
using Persistencia.RepositoryFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servico.ServicoFolders
{
     public class ConsultaServico
    {
        private Repositorio<Consulta> repositorio = new Repositorio<Consulta>();
        public void Gravar(Consulta consulta)
        {
            repositorio.Gravar(consulta);

        }
        public void Atualizar(Consulta consulta)
        {
            repositorio.Atualizar(consulta);

        }
        public IEnumerable<Consulta> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
        public IQueryable<Consulta> Buscar(Func<Consulta, bool> func)
        {
            return repositorio.Buscar(func);
        }
        public void Excluir(Func<Consulta, bool> func)
        {

            repositorio.Excluir(func);
        }
    }
}
