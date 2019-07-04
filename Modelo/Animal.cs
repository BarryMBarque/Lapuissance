using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Data;

namespace Modelo
{
    public class Animal
    {
        public int AnimalID { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteID { get; set; }
        public string Proprietario { get; set; }


        public virtual Cliente Cliente { get; set; }
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Tipo { get; set; }

        public string Sub_tipo { get; set; }

        public string Raca { get; set; }

        public DateTime Date { get; set; }
        public virtual IList<Consulta> Consultas { get; set; }
        public virtual IList<Tratamento> Tratamentos   { get; set; }
    }
}
