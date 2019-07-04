using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelo
{
    public class Atendimento
    { 
        public int AtendimentoID { get; set; }

        public string Nome { get; set; }

        [ForeignKey("Animal")]
        public int AnimalID { get; set; }

        [ForeignKey("Medico")]
        public int MedicoID { get; set; }

        public DateTime Date { get; set; }
        public string Descripcao { get; set; }
         
        public double Preco { get; set; }

         public int Proprietario { get; set; }

     

        public string  Medicamento { get; set; }
        public virtual Animal animals { get; set; }
        public virtual Medico Medicos { get; set; }

        public virtual ContaClinica ContaClinica { get; set; }
    
       


    }
}
