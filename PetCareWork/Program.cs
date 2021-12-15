using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PetCareWork.Forms;
using PetCareWork.Classes;

namespace PetCareWork
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

            // form de login
            FrmLogin flogin = new FrmLogin();
            flogin.ShowDialog();

            //Pode-se trabalhar nos "ifs" dependendo do tipo de usuario
            if (Util.tipo_usuario != 0)
            {
                Application.Run(new FrmPrincipal());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
