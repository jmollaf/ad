using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;//Para poder usar list

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

			
		
			showColumnNames (mySqlDataReader);
			show (mySqlDataReader);
			mySqlDataReader.Close ();
			mySqlConnection.Close();

		}

		private static void showColumnNames (MySqlDataReader mySqlDataReader) {
			//SOLUCION MIA
			int numeroColumnas = mySqlDataReader.FieldCount;
			for (int i=0;i<numeroColumnas;i++)
			    {
			      Console.Write (mySqlDataReader.GetName(i) + " ");
			    }

			/*SOLUCION PROFESOR 1
			Console.WriteLine ("showColumnNames...");
			for (int index = 0; index < mySqlDataReader.FieldCount; index++) {
				Console.WriteLine ("index=" + index + " columna=" + mySqlDataReader.GetName (index));
			}
            */
			/*SOLUCION PROFESOR 2 CON ARRAY
             int count= mySqlDataReader.FieldCount;
             string[] columNames = new string[count];
             for(int index =0; index <count; index++){
                 columNames [index] = mySqlDataReader.GetName (index);
             }
             foreach (string columnName in columnNames){
                 console.WriteLine ("Columna=" +columnName);
             }
			*/

	    }
		/*SOLUCION PROFESOR 3 CON LISTAS DINAMICAS*/
		private static string[] getColumnNames(MySqlDataReader mySqlDataReader){
			int count = mySqlDataReader.FieldCount;
			List<string> columnNames = new List<string> ();
			for (int index = 0; index < count; index++) {
				columnNames.Add (mySqlDataReader.GetName (index));
			}
			return columnNames.ToArray ();
		}
		private static void show(MySqlDataReader mySqlDataReader){
			Console.WriteLine ();
			while (mySqlDataReader.Read()) {
				Console.WriteLine ("{0}    {1}     {2}", mySqlDataReader ["id"], mySqlDataReader ["nombre"], mySqlDataReader["precio"]);

			}
		}
		private static void updateDatabase(MySqlConnection mySqlConnection){
			MySqlCommand mySqlCommand = mySqlConnection.CreateCommand ();
			mySqlCommand.CommandText = "update articulo set categoria=null where id=4";
			mySqlCommand.ExecuteNonQuery ();
		}
	}
}
