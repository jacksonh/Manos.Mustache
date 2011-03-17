
Manos.Mustache lets you use mustache views in your Manos's applications.


For more information on mustache: http://mustache.github.com/

This project uses the wonderful Nustache project:  https://github.com/jdiamond/Nustache


To use this project just drop the Manos.Mustache.cs file into your project and add a using Manos.Mustache statement.

Your template files should be stored in the Templates directory and can use any extension you want.  You must specify your extension in the path passed to RenderStache though.

Example
-------

    using System;
    using Manos;
    using Manos.Mustache;


    public class Test : ManosModule {

       public TestModule ()
       {
          Get ("/", ctx => {
              this.RenderStache ("index.stache", new {
                  name = "Jackson",
                  value = "magnificent",
              });
          });
       }
    }


index.stache:

   <html>
    <head>
     <title>Hey Stachers!</title>
    </head>
    <body>
     Hey {{name}} you have a {{value}} stache!
    </body>
   </html>
