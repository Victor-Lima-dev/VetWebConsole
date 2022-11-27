using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetWebConsole
{
    public class Animal
    {
        public string Nome { get; set; }
        public string FaseDaVida { get; set; }

        public string Sexo { get; set; }
        public string Comorbidade { get; set; }
        public string Condicao { get; set; }
        public Parametros Parametros { get; set; }
    }
}
