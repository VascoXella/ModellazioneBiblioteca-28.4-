﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellazioneBiblioteca_28._4_
{
    internal class Prestito: Persona
    {
        public string Numero { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al{ get; set; }
    }
}
