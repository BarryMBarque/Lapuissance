using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Identidade { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime Date { get; set; }
      
        public virtual IList<Cliente> clientes { get; set; }

    }
}
