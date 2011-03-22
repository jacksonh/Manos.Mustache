using System;
using System.IO;
using Nustache.Core;


namespace Manos.Mustache {

	  public static class ManosMustache {

	  	private static readonly string TEMPLATE_DIR = "Templates";
	  	private static FileSystemTemplateLocator locator = new FileSystemTemplateLocator (String.Empty, TEMPLATE_DIR);

	  	public static void RenderStache (this ManosModule mod, IManosContext ctx, string template, object obj)
	  	{
			var t = new Template ();
			var path = Path.Combine (TEMPLATE_DIR, template);
			using (var r = new StreamReader (path)) {
			      t.Load (r);
  		        }

			t.Render (obj, new StreamWriter (ctx.Response.Writer), locator.GetTemplate);
			ctx.Response.End ();

	  	}

		public static string RenderStache (this ManosModule mod, string template, object obj) {
			var t = new Template ();
			var path = Path.Combine (TEMPLATE_DIR, template);
			using (var r = new StreamReader (path)) t.Load (r);

			var writer = new StringWriter ();
			t.Render (obj, writer, locator.GetTemplate);
			return writer.ToString ();
		}
	}
}

