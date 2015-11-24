using System;

namespace PArticulo
{
	public partial class ArticuloView : Gtk.Window
	{
		public ArticuloView () : 
				base(Gtk.WindowType.Toplevel)
		{
			this.Build ();
			entryNombre.Text = "nuevo";
			spinButtonPrecio.Value = 1.5;
		}
		/*generado por el diseñador*/
		protected void OnRefreshActionActivated (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}
		/*generado por el diseñador*/
		protected void OnNewActionActivated (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

   }
}
