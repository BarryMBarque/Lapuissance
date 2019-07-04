using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
   public  class Cliente
    {
        public int ClienteID { get; set; }
        [ForeignKey("Funcionario")]
        public int FuncionarioID { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Identidade { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime Date { get; set; }
        public string  Conta { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual IList<Animal> animals { get; set; }
        

    }
}
