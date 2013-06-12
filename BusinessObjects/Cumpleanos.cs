using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
   public class Cumpleanos
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _body;

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _contrasena;

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        private int _dias;

        public int Dias
        {
            get { return _dias; }
            set { _dias = value; }
        }


        private bool _imagen;

        public bool Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
        private string _adjunto;

        public string Adjunto
        {
            get { return _adjunto; }
            set { _adjunto = value; }
        }

    }
}
