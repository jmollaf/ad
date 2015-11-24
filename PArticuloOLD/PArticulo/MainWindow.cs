using System;

using Gtk;

using PSerpisAd;
using PArticulo;
public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		Console.WriteLine ("MainWindow ctor.");
		QueryResult queryResult = PersisterHelper.Get ("select * from articulo");
		TreeViewHelper.Fill (treeView, queryResult);

		/*Asociar codigo a accion manualmente
		newAction.ActivateDefault += delegate {
			new ArticuloView ();
		};
        */
	}


	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnNewActionActivated (object sender, EventArgs e){
		new ArticuloView ();
	}


}
