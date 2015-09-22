using System;
using MySql.Data.MySqlClient;

namespace PMySql
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Creamos objeto de conexion
			MySqlConnection mySqlConnection = new MySqlConnection (
				"Database=dbprueba;Data Source=localhost;User Id=root;Password=sistemas"//Cadena de conexion
				);
			mySqlConnection.Open();
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = "select * from articulo";
			MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader ();
			while (mySqlDataReader.Read()) {
				Console.WriteLine ("id={0} nombre={1}", mySqlDataReader ["id"], mySqlDataReader ["nombre"]);
			
			}
			mySqlDataReader.Close ();
			mySqlConnection.Close();

		}
	}
	}
