using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTestSender
{
    class Nachricht
    {
        private string wert1;
        private string wert2;

        public string Wert1 { get => wert1; set => wert1 = value; }
        public string Wert2 { get => wert2; set => wert2 = value; }

        public Nachricht()
        {
            Wert1 = "Hallo";
            Wert2 = "Freunde";
        }

        public void init(string value1,string value2)
        {
            Wert1 = value1;
            Wert2 = value2;
        }
    }
}
