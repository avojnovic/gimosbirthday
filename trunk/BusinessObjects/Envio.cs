using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
   public class Envio
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private DateTime _fechaEnvio;

        public DateTime FechaEnvio
        {
            get { return _fechaEnvio; }
            set { _fechaEnvio = value; }
        }
        private string texto;

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

    }
}
