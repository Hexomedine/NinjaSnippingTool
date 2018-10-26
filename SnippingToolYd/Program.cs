using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinjaSnippingTool
{
    static class Program
    {
        //Si plusieur instance voulu
        //private static OcrResultForm _singleOcrResultForm = null;
        //public static OcrResultForm GetSingleOcrResultForm()
        //{
        //    if (_singleOcrResultForm == null || _singleOcrResultForm.IsDisposed)
        //        _singleOcrResultForm = new OcrResultForm();

        //    return _singleOcrResultForm;
        //}

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>        
        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            args = new string[] { "lol" };


            // var snapSrv = new SnapSrv();


            if (args != null && args.Any())
            {
                if (args[0] == "-auto")
                {
                    Application.Run(new SnapForm(true));
                }
                else { Application.Run(new SnapForm()); }

            }
            else
            {
                SnapService.StartNewSnap();
            }

            //Application.Run(maform);

        }
    }
}
