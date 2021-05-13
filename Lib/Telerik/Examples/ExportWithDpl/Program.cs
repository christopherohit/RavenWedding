using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Themes;

namespace ExportWithDpl
{
    static class Program
    {
        public static string themeName = "";
        public static string loadedExample = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                Program.loadedExample = "GridView";
                Program.themeName = args[0];
            }
            else if (args.Length == 2)
            {
                Program.loadedExample = args[0];
                Program.themeName = args[1];
            }
            else
            {
                Program.loadedExample = "GridView";
                Program.themeName = "TelerikMetro";
            }

            //reuse the database from Examples\DataSources
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));

            string testPathForDebuggingCase = Path.GetFullPath(Path.Combine(path, @"..\..\..\Examples\DataSources"));
            string fileName = "Nwind.mdb";

            if (File.Exists(Path.Combine(testPathForDebuggingCase, fileName)))
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", testPathForDebuggingCase);
            }

            string testPathForInstallationCase = Path.GetFullPath(Path.Combine(path, @"..\..\QuickStart\DataSources"));

            if (File.Exists(Path.Combine(testPathForInstallationCase, fileName)))
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", testPathForInstallationCase);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //we need this to load the needed references from other directory (for the standalone QSF)
            AppDomain.CurrentDomain.AssemblyResolve += MyResolveEventHandler;
            
            //Load the themes so the form can start with the QSF theme
            LoadThemes();

            //run the manually created instance. This is needed as otherwise the static types of the assemblies will be needed prior we get here
            new ExportWithDplExamplesApplication().Run(args);
        }

        class ExportWithDplExamplesApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
        {
            protected override void OnCreateMainForm()
            {
                Form exampleForm = Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().GetType(String.Format("ExportWithDpl.{0}.Form1", Program.loadedExample))) as Form;
                this.MainForm = exampleForm;
            }
        }

        private static System.Reflection.Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            string strTempAssmbPath = "";
            string neededAssembly = args.Name.Contains(',') ? args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll" : args.Name + ".dll";
            System.Reflection.Assembly objExecutingAssemblies = System.Reflection.Assembly.GetExecutingAssembly();

            foreach (System.Reflection.AssemblyName strAssmbName in objExecutingAssemblies.GetReferencedAssemblies())
            {
                string currentAssembly = strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) + ".dll";

                if (currentAssembly == neededAssembly)
                {
                    strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll");

                    if (!System.IO.File.Exists(strTempAssmbPath)) // we are in the case of QSF as exe, so the Path is different
                    {
                        strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\\..\\..\\bin\\ReleaseTrial\\");
                        strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, neededAssembly);
                    }
                    break;
                }
            }

            System.Reflection.Assembly myAssembly = null;

            if (!string.IsNullOrEmpty(strTempAssmbPath))
            {
                myAssembly = System.Reflection.Assembly.LoadFrom(strTempAssmbPath);
            }
            return myAssembly;
        }

        private static void LoadThemes()
        {
            new AquaTheme();
            new BreezeTheme();
            new DesertTheme();
            new HighContrastBlackTheme();
            new Office2007BlackTheme();
            new Office2007SilverTheme();
            new Office2010BlackTheme();
            new Office2010SilverTheme();
            new Office2010BlueTheme();
            new Office2013DarkTheme();
            new Office2013LightTheme();
            new TelerikMetroTheme();
            new TelerikMetroBlueTheme();
            new TelerikMetroTouchTheme();
            new VisualStudio2012DarkTheme();
            new VisualStudio2012LightTheme();
            new Windows7Theme();
            new Windows8Theme();
        }
    }
}
