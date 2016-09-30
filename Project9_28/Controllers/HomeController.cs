using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
//using System.Scripting;
using System.Text;
using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System.Diagnostics;

//Install-Package IronPython.StdLib
//Install-Package IronPython
// reference Assemply System.Configuration

namespace Project9_28.Controllers
{
    public class HomeController : Controller
    {
        public void PythonExecute()
        {

            // ScriptRuntime runTime = ScriptRuntime.Create();
            ScriptRuntime runTime = ScriptRuntime.CreateFromConfiguration();
            ScriptEngine pyEngine = runTime.GetEngine("py");
            MemoryStream ms = new MemoryStream();
            string str = "";
            //runTime.IO refers to the current runtime’s IO property

            runTime.IO.SetOutput(ms, new StreamWriter(ms));
            runTime.IO.SetOutput(ms, new StreamWriter(ms));
            ScriptSource ss = pyEngine.CreateScriptSourceFromString("print 'hello world from rakhi'\nprint 5+6", SourceCodeKind.Statements);
            try { ss.Execute(); 
            str = ReadFromStream(ms);
            ms.Close();
            Debug.WriteLine(str); }
            catch (Exception e)
            {
                str = e.Message;
                //str = ReadFromStream(ms);
                ms.Close();
                Debug.WriteLine(str);
            }
            // Console.ReadLine();
            //return View();
        }
        private static string ReadFromStream(MemoryStream ms)
        {

            int length = (int)ms.Length;
            //Console.WriteLine("length: {0}", length);
            Byte[] bytes = new Byte[length];
            ms.Seek(0, SeekOrigin.Begin);
            ms.Read(bytes, 0, (int)ms.Length);
            return Encoding.GetEncoding("utf-8").GetString(bytes, 0, (int)ms.Length);
            // return Encoding.Default.GetString(bytes, 0, (int)ms.Length);

        }

        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}