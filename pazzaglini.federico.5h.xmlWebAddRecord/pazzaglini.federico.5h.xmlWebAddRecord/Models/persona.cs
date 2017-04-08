using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace pazzaglini.federico._5h.xmlWebAddRecord.Models
{
    public class persona
    {

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Stato { get; set; }

        public persona()
        { }

        public persona(XElement riga)
        {
            Nome = riga.Attribute("Nome").Value;
            Cognome = riga.Attribute("Cognome").Value;
            Stato = riga.Attribute("Stato").Value;

        }
    }
}