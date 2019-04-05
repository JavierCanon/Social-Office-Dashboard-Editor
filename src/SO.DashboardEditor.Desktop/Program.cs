// Copyright (c) 2019 Javier Cañon 
// https://www.javiercanon.com 
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
using SO.DashboardEditor.Desktop.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using Microsoft.Win32;
using System.Configuration;
using System.Threading.Tasks;
using log4net;

namespace SO.DashboardEditor.Desktop
{
    static class Program
    {

        private static ILog ilog;

        // PUBLIC VARS        
        public static class Development
        {
            public static class Settings
            {
                public static bool Is_InDevMode;
            }

        }

        public static class SO
        {
            public static class User
            {
                public static string GUID;
                public static string Email;
                public static string Alias;

            }

        }


        public static class Configuration
        {
            public static class Webserver
            {

                public static string URL_Development;
                public static string URL_Production;
            }

            public static class Logger
            {

                public static bool Logger_LogDebugInfo;

            }

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SetAppSettings();
            InitiateLogging();

            // https://docs.microsoft.com/en-us/dotnet/framework/winforms/high-dpi-support-in-windows-forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); // try directx?

            // culture and localization
            // https://msdn.microsoft.com/en-us/goglobal/bb896001.aspx

            // Create a new object, representing the culture.  
            CultureInfo culture = CultureInfo.CreateSpecificCulture("es-MX");

            // The following line provides localization for the application's user interface.  
            Thread.CurrentThread.CurrentUICulture = culture;

            // The following line provides localization for data formats.  
            Thread.CurrentThread.CurrentCulture = culture;

            // Set this culture as the default culture for all threads in this application.  
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;


            // Application.Run(new RibbonFormDashboardDesigner());
            // Application.Run(new FluentDesignFormMain()); // bug in side menu hdpi displays
            Application.Run(new RibbonFormMain());
        }


        static void SetAppSettings()
        {

#if DEBUG
            Program.Development.Settings.Is_InDevMode = true;
#else
            Program.Development.Settings.Is_InDevMode = false;
#endif

            Configuration.Webserver.URL_Development = ConfigurationManager.AppSettings["Webserver.Development"];
            Configuration.Webserver.URL_Production = ConfigurationManager.AppSettings["Webserver.Production"];


            Configuration.Logger.Logger_LogDebugInfo = Convert.ToBoolean(ConfigurationManager.AppSettings["Logger.LogDebugInfo"]);

        }

        static void SetIEVersion()
        {
            // https://blogs.msdn.microsoft.com/patricka/2015/01/12/controlling-webbrowser-control-compatibility/
            // fallback is set in header of webpage: <meta http-equiv="X-UA-Compatible" content="IE=edge">

            int BrowserVer, RegVal;
            RegistryKey Regkey = null;


            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
            {

                BrowserVer = Wb.Version.Major;

                // set the appropriate IE version
                if (BrowserVer >= 11)
                    RegVal = 11001;
                else if (BrowserVer == 10)
                    RegVal = 10001;
                else if (BrowserVer == 9)
                    RegVal = 9999;
                else if (BrowserVer == 8)
                    RegVal = 8888;
                else
                    RegVal = 7000;


                LogInfo("set IE version to " + RegVal);

                // set the actual key
                Regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
                Regkey.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
                Regkey.Close();


                Wb.Dispose();

            }






        }


        #region Comun

        static void InitiateLogging()
        {
            log4net.Config.XmlConfigurator.Configure();
            ilog = LogManager.GetLogger("loggerConsole");
            LogInfo(">> Iniciando Consola...");
        }

        static void PrintHelp()
        {
            // System.Console.WriteLine( "Usage:" );
            // System.Console.WriteLine( "Subir Planos: -catplano=< Mercadeo = 1,Novedades = 2,Presupuestos = 3> -file=<ruta y nombre archivo texto csv> -email=<aviso@correo.com> -empresa=<nombre empresa creada en AV>" );
            // System.Console.WriteLine( "Mover y Procesar Planos Ventas: -moverplanos=1 -empresa=<nombre empresa creada en AV>" );
            // System.Console.WriteLine( "Cargar Pagina Web: -webrequest=http://localhost/mipagina.html -software=<nombre software>" );
        }

        public static void LogError(string msg)
        {
            // System.Console.WriteLine("[Browser Chrome] Error: " + msg);
            ilog.Error(msg);
        }

        public static void LogInfo(string msg)
        {
            // System.Console.WriteLine("[Browser Chrome] Info: " + msg);
            ilog.Info(msg);
        }

        public static void LogDebug(string msg)
        {
            // System.Console.WriteLine("[Browser Chrome] Debug: " + msg);
            if (Configuration.Logger.Logger_LogDebugInfo)
                ilog.Debug(msg);
        }

        #endregion Comun

        #region Metodos



        #endregion Metodos

    }
}
