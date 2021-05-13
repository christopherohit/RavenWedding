using System;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Linq;

namespace Telerik.QuickStart.WinControls
{
    static class Program
    {
        public static string themeName = "";
        public static string exampleName = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Contains("-ToastActivated"))
            {
                // if the QSF is started because of toast notification - do not start it
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.AssemblyResolve += MyResolveEventHandler;

            //Attempt to load the QuickStart assembly from GAC - for the installation purpose
            Assembly quickStartAssembly = Assembly.Load("QuickStart" + " , Version=" + Telerik.WinControls.VersionNumber.Number + Telerik.WinControls.DesignerConsts.KeyToken);

            //run the manually created instance. This is needed as otherwise the static types of the assemblies will be needed prior we get here
            Form mainForm = Activator.CreateInstance(quickStartAssembly.GetType("Telerik.QuickStart.WinControls.MainForm")) as Form;

            Application.ApplicationExit += delegate(object sender, EventArgs e)
            {
                //we have to call this method when the app exits
                mainForm.GetType().GetMethod("ApplicationStop", BindingFlags.Public | BindingFlags.Instance).Invoke(mainForm, null);
            };

            Application.Run(mainForm);
        }

        private static Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            string strTempAssmbPath = "";
            string neededAssembly = "";

            if (args.Name.Contains(","))
            {
                neededAssembly = args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll";
            }
            else
            {
                neededAssembly = args.Name;
            }

            Assembly objExecutingAssemblies = Assembly.GetCallingAssembly();
            foreach (AssemblyName strAssmbName in objExecutingAssemblies.GetReferencedAssemblies())
            {
                string currentAssembly = strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) + ".dll";
                if (currentAssembly == neededAssembly)
                {
                    strTempAssmbPath = Path.Combine(Directory.GetCurrentDirectory(), neededAssembly);
                    if (!File.Exists(strTempAssmbPath)) // we are in the case of QSF as exe, so the Path is different
                    {
                        strTempAssmbPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\bin\\ReleaseTrial\\");
                        strTempAssmbPath = Path.Combine(strTempAssmbPath, neededAssembly);
                    }

                    break;
                }
            }

            Assembly myAssembly = null;

            if (!string.IsNullOrEmpty(strTempAssmbPath))
            {
                myAssembly = Assembly.LoadFrom(strTempAssmbPath);
            }
            else
            {
                strTempAssmbPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\bin\\ReleaseTrial\\");
                if (Directory.Exists(strTempAssmbPath))
                {
                    foreach (string fileName in Directory.GetFiles(strTempAssmbPath, "*.dll"))
                    {
                        if (fileName.EndsWith(neededAssembly))
                        {
                            myAssembly = Assembly.LoadFrom(Path.Combine(strTempAssmbPath, fileName));
                            break;
                        }
                    }
                }
            }

            return myAssembly;
        }
    }
}