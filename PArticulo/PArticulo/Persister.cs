using System;
using System.Data;
using System.Reflection;
using System.Collections.Generic;

namespace SerpisAd
{
	public class Persister
	{
			public static int Insert(object obj) {
				Console.WriteLine ("Persister.insert");
				Type type = obj.GetType ();
			    string[] fieldNames = getFieldNames (type);
			    string[] paramNames = getParamNames (fieldNames);
			    string insertSql = "insert into {0} {{1}} values {{2}}";
			    
			}
		    
		    public static string[] getFieldNames(Type type) {
			       //LISTA PARA GUARDAR LOS NOMBRES DE LOS CAMPOS
			       List<string> fieldNames = new List<string> ();
			       PropertyInfo[] propertyInfos = type.GetProperties ();
			       foreach (PropertyInfo propertyInfo in propertyInfos) {
				            if (!propertyInfo.Name.Equals ("Id")) {
					           fieldNames.Add (propertyInfo.Name.ToLower ());
				            }
				   return fieldNames.ToArray ();
			       }
		    }
		    //RECOGER LOS PARAMETROS

			public static string[] getParamNames(string[] fieldNames){
			       List<string> paramNames = new List <string> ();
			       foreach (string fieldName in fieldNames) {
			          	   paramNames.Add ("@", fieldName);
				   }
			return paramNames.ToArray ();
			}

	}
}


