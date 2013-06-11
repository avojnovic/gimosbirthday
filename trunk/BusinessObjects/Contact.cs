using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
   public class Contact
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private DateTime _fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private DateTime _fechaAlta;

        public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
        private DateTime? _fechaModificacion;

        public DateTime? FechaModificacion
        {
            get { return _fechaModificacion; }
            set { _fechaModificacion = value; }
        }

        public int DiasParaCumpleanos
        {
            get {

                DateTime today = DateTime.Today;
                DateTime next = _fechaNacimiento.AddYears(today.Year - _fechaNacimiento.Year);

                if (next < today)
                    next = next.AddYears(1);

                int numDays = (next - today).Days;

                return numDays; 
            
           
                }
          
        }


    }
}
