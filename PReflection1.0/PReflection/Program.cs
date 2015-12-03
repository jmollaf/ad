using System;
using System.Reflection;

namespace PReflection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		//	int i=33;
		//	Type typeI = i.GetType ();
		//	Console.WriteLine("TypeInitializationException.Name={0}", typeI.Name);

        //	string s="Hola Segismundo";
		//	Type typeS = s.GetType ();
		//	Console.WriteLine("TypeInitializationException.Name={0}", typeS.Name);
		//	Type typeX = typeof(string);//typeX contendria lo mismo que typeS
		//	Console.WriteLine("TypeInitializationException.Name={0}", typeX.Name);
		    
			//Llamando a metodo showType pasandole como argumento la variable
		//	showType (typeX);
			//Ahora pasando una clase a ver que saca
		//	Type typeFoo = typeof(Foo);
		//	showType (typeFoo);
			//Probamos el de object
		//	Type type0 = typeof(object);
		//	showType (type0);
			//object no depende de nadie su basetype es null
		}

		private static void showType(Type type) {
			Console.WriteLine ("type.Name={0} type.FullName={1}", type.Name, type.FullName);
			PropertyInfo[] propertyInfos = type.GetProperties ();
			foreach (PropertyInfo propertyInfo in propertyInfos) {
				Console.WriteLine ("property.Name={0} property.PropertyInfo={1}", propertyInfo.Name, propertyInfo.PropertyType);
			}
		  
		}
	}
	public class Foo {
		private String name;
		public object id;

		public object Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}
		
		public String Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
	}
}
