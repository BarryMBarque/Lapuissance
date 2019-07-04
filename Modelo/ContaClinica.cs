using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
     public class ContaClinica
    {
        public int ContaCLinicaID { get; set; }

        public int  AtendimentoID { get; set; }

        public string  Tipo { get; set; }

        public double Preco { get; set; }

        public DateTime Datapagamento { get; set; }

        public virtual IList<Atendimento> Atendimentos { get; set; }




    }
}
