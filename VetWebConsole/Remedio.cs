using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetWebConsole
{
    public class Remedio
    {
        public string Nome { get; set; }
        public string PrincipioAtivo { get; set; }

        public string MecanismoAcao { get; set; }
        public string ViaAdministracao { get; set; }
        public string EfeitoSistemico { get; set; }
        public string EfeitoAdverso { get; set; }
    }
}
