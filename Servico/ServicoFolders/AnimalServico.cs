using Modelo;
using NUnit.Framework;
using Persistencia.RepositoryFolders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Servico.ServicoFolders
{
   public  class AnimalServico
    {
        private Repositorio<Animal> repositorio = new Repositorio<Animal>();
        public void Gravar(Animal animal)
        {
            repositorio.Gravar(animal);

        }
        public IEnumerable<Animal> ObterTodosInclude()
        {
            return repositorio.ObterTodos();
        }
        public void Atualizar(Animal animal)
        {
            repositorio.Atualizar(animal);

        }
        public IQueryable<Animal> Buscar(Func<Animal, bool> func)
        {
            return repositorio.Buscar(func);
        }
    }
}
