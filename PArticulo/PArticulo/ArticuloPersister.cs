using System;
using System.Data;
using SerpisAd;

namespace PArticulo
{
	public class ArticuloPersister
	{
		public static Articulo Load( object id) {
			  throw new NotImplementedException(); 
		} 

		public static void Insert(Articulo articulo){
			IDbCommand dbCommand = App.Instance.DbConnection.CreateCommand ();
			dbCommand.CommandText = "insert into articulo (nombre, categoria, precio) " +
				"values(@nombre,@categoria,@Precio)";
			DbCommandHelper.AddParameter (dbCommand, "nombre", articulo.Nombre);
			DbCommandHelper.AddParameter (dbCommand, "categoria", articulo.Categoria);
			DbCommandHelper.AddParameter (dbCommand, "precio", articulo.Precio);
			dbCommand.ExecuteNonQuery ();
		}
		public static void Update(Articulo articulo){

		}
	}
}

