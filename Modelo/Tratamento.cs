﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Modelo
{
   public class Tratamento
    {
        public int TratamentoID { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Tratamento { get; set; }
        public double Preco { get; set; }

        [ForeignKey("Animal")]
        public int AnimalID { get; set; }

        [ForeignKey("Medico")]
        public int MedicoID { get; set; }

        public string Descripcao { get; set; }
        public int Proprietario { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Medico Medico { get; set; }


    }
}
