﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Loguin login = new Loguin();

            if (login.ShowDialog() == DialogResult.OK)
            {
             feature/sebastian
                Application.Run(new Form1(login.NombreUsuario));

            }


        }
    }
}
