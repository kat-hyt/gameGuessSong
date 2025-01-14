﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Guess_Melody_Framework
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
            //Application.Run(new Form1());

            //Application.Run(new fGame());
            //Application.Run();
            
            var thread = new Thread(ThreadStart);
            //allow UI with ApartmentState.STA though [STAThread] above should give that to you
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            Application.Run(new fGame());
            
        }

        private static void ThreadStart()
        {
            Application.Run(new Form1()); // <-- other form started on its own UI thread
        }
    }
}

