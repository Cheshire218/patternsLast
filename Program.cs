using System;
using System.Windows.Forms;

namespace ActiveMVC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ActiveMVCForm view = new ActiveMVCForm();
            IModel mdl = new ListModel();
            IController cnt = new IncrementController(view, mdl);
            Application.Run(view);
        }
    }
}
