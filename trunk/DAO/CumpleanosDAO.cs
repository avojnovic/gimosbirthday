using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessObjects;
using System.Data.OleDb;
using System.Data;

namespace DAO
{
   public static class CumpleanosDAO
    {
        public static List<Cumpleanos> get(string dbPath)
        {
            string connection = DAO.Properties.Settings.Default.ConnectionString;
            connection = connection.Replace("PATH", dbPath);


            OleDbConnection con = new OleDbConnection(connection);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Cumpleanos", con);
            OleDbDataReader reader = cmd.ExecuteReader();


            List<Cumpleanos> cumpleanos = new List<Cumpleanos>();
            while (reader.Read())
            {
                Cumpleanos c = new Cumpleanos();

                c.Id = reader.GetInt32(0);
                c.Body = reader.GetString(1);
                c.Subject = reader.GetString(2);
                c.Email = reader.GetString(3);
                c.Contrasena = reader.GetString(4);
                c.Dias = reader.GetInt32(5);
                
                cumpleanos.Add(c);
            }
            reader.Close();

            return cumpleanos;

        }


        public static void update(string dbPath, Cumpleanos c)
        {
            string strconnection = DAO.Properties.Settings.Default.ConnectionString;
            strconnection = strconnection.Replace("PATH", dbPath);


            OleDbConnection connection = new OleDbConnection(strconnection);



            OleDbCommand cmd = new OleDbCommand();

            cmd.CommandText = @"UPDATE Cumpleanos SET Body=@Body,Subject=@Subject,Email=@Email,Contrasena=@Contrasena,DiasAntes=@DiasAntes";

            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Body", OleDbType.VarChar, 255).Value = c.Body;
            cmd.Parameters.Add("@Subject", OleDbType.VarChar, 255).Value = c.Subject;
            cmd.Parameters.Add("@Email", OleDbType.VarChar, 255).Value = c.Email;
            cmd.Parameters.Add("@Contrasena", OleDbType.VarChar, 255).Value = c.Contrasena;
            cmd.Parameters.Add("@DiasAntes", OleDbType.Integer, 255).Value = c.Dias;
            //cmd.Parameters.Add("@ID", OleDbType.Integer, 255).Value = c.Id;



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
