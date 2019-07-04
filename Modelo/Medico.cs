using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
     public class Medico
    {
        public int MedicoID { get; set; }
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string CRM { get; set; }

        public string Especialidade { get; set; }

        public string Identidade { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public DateTime Date { get; set; }

        public virtual IList<Consulta>  Consultas { get; set; }
        public virtual IList<Tratamento> Tratamentos { get; set; }
        public virtual IList<Atendimento> Atendimentos { get; set; }
     
    }
}
