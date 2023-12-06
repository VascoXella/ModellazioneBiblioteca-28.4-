using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellazioneBiblioteca_28._4_
{
    internal class Documento: Autore //, Scaffale
    {
        public string codice { get; set; }
        public string settore { get; set; }
        public string stato { get; set; }
        public string titolo { get; set; }
        public int anno { get; set; }


    }
}
