using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Reflection;
using System.IO;
using BusinessObjects;
using System.Data;


namespace DAO
{
    public static class ContactDAO
    {

        public static Dictionary<int,Contact> get(string dbPath)
        {
            string connection = DAO.Properties.Settings.Default.ConnectionString;
            connection = connection.Replace("PATH", dbPath);


            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Contactos", con);
            OleDbDataReader reader = cmd.ExecuteReader();


            Dictionary<int, Contact> contacts = new Dictionary<int, Contact>();
            while (reader.Read())
            {
                Contact c = new Contact();

                c.Id = reader.GetInt32(0);
                c.Nombre = reader.GetString(1);
                c.Apellido = reader.GetString(2);
                c.FechaNacimiento = reader.GetDateTime(3);
                c.Email = reader.GetString(4);
                c.FechaAlta = reader.GetDateTime(5);
                if (!reader.IsDBNull(6))
                c.FechaModificacion = reader.GetDateTime(6);

                contacts.Add(c.Id,c);
            }
            reader.Close();

            return contacts;

        }


        public static int insert(string dbPath, Contact c)
        {
            string strconnection = DAO.Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);
           


            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = @"INSERT INTO CONTACTOS (NOMBRE,APELLIDO,FECHANACIMIENTO,EMAIL, FECHAALTA) 
                                VALUES(@NOMBRE,@APELLIDO,@FECHANACIMIENTO,@EMAIL, @FECHAALTA)";

            cmd.CommandType = CommandType.Text;


            cmd.Parameters.Add("@NOMBRE", OleDbType.VarChar, 255).Value = c.Nombre;
            cmd.Parameters.Add("@APELLIDO", OleDbType.VarChar, 255).Value = c.Apellido;
            cmd.Parameters.Add("@FECHANACIMIENTO", OleDbType.Date, 255).Value =  c.FechaNacimiento.ToShortDateString();
            cmd.Parameters.Add("@EMAIL", OleDbType.VarChar, 255).Value =  c.Email;
            cmd.Parameters.Add("@FECHAALTA", OleDbType.Date, 255).Value = c.FechaAlta;


            cmd.Connection = connection;
            connection.Open();
            //cmd.Transaction = connection.BeginTransaction();

            int rows= cmd.ExecuteNonQuery();

            string query2 = "Select @@Identity";
            int ID;

            cmd.CommandText = query2;
            ID = (int)cmd.ExecuteScalar();

           // cmd.Transaction.Commit();
            connection.Dispose();
            connection.Close();


            return ID;
        }

        public static void update(string dbPath, Contact c)
        {
            string strconnection = DAO.Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);



            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = @"UPDATE CONTACTOS SET NOMBRE=@NOMBRE,APELLIDO=@APELLIDO,FECHANACIMIENTO=@FECHANACIMIENTO,EMAIL=@EMAIL,FechaModificacion=@FechaModificacion  WHERE ID=@ID";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@NOMBRE", OleDbType.VarChar, 255).Value = c.Nombre;
            cmd.Parameters.Add("@APELLIDO", OleDbType.VarChar, 255).Value = c.Apellido;
            cmd.Parameters.Add("@FECHANACIMIENTO", OleDbType.Date, 255).Value = c.FechaNacimiento.ToShortDateString();
            cmd.Parameters.Add("@EMAIL", OleDbType.VarChar, 255).Value = c.Email;
            cmd.Parameters.Add("@FechaModificacion", OleDbType.Date, 255).Value = c.FechaModificacion.Value.ToString();
            cmd.Parameters.Add("@ID", OleDbType.Integer, 255).Value = c.Id;
         


            cmd.Connection = connection;
            connection.Open();
            cmd.Transaction = connection.BeginTransaction();

            int rows = cmd.ExecuteNonQuery();


            cmd.Transaction.Commit();
            connection.Dispose();
            connection.Close();
        }
    }
}
