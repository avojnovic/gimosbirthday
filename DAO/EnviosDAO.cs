using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;
using System.Data.OleDb;
using System.Data;

namespace DAO
{
   public static class EnviosDAO
    {

       public static List<Envio> get(string dbPath, Contact c)
       {
           string connection = DAO.Properties.Settings.Default.ConnectionString;
           connection = connection.Replace("PATH", dbPath);


           OleDbConnection con = new OleDbConnection(connection);
           OleDbCommand cmd = new OleDbCommand("SELECT * FROM Envios where ID_Contacto=@ID", con);

           cmd.Parameters.Add("@ID", OleDbType.Integer, 255).Value = c.Id;
           con.Open();

           OleDbDataReader reader = cmd.ExecuteReader();


           List<Envio> Envios = new List<Envio>();
           while (reader.Read())
           {
               Envio e = new Envio();
               e.Id = reader.GetInt32(0);
               e.FechaEnvio = reader.GetDateTime(1);
               e.Texto = reader.GetString(3);

               Envios.Add(e);
           }
           reader.Close();

           return Envios;

       }




       public static void Insertar(string dbPath, Contact c, Envio e)
       {
           string strconnection = DAO.Properties.Settings.Default.ConnectionString;
           strconnection = strconnection.Replace("PATH", dbPath);


           OleDbConnection connection = new OleDbConnection(strconnection);



           OleDbCommand cmd = new OleDbCommand();

           cmd.CommandText = @"INSERT INTO ENVIOS (FECHAENVIO,ID_CONTACTO,TEXTO) 
                                VALUES(@FECHAENVIO,@ID_CONTACTO,@TEXTO)";

           cmd.CommandType = CommandType.Text;


           cmd.Parameters.Add("@FECHAENVIO", OleDbType.Date, 255).Value = e.FechaEnvio.ToShortDateString();
           cmd.Parameters.Add("@ID_CONTACTO", OleDbType.Integer, 255).Value = c.Id;
           cmd.Parameters.Add("@TEXTO", OleDbType.VarChar, 255).Value = e.Texto;


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
