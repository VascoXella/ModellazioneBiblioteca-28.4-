using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellazioneBiblioteca_28._4_
{
    enum stato {InPrestito, Disponibile}

    internal class Stato
    {
        public stato InPrestito { get; set; }
        public stato disponibile { get; set; }
    }
}
