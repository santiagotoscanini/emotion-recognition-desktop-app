﻿using BusinessLogic;
using BusinessLogic.BD;
using System;
using System.Windows.Forms;

namespace emotionRecognition
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow(new BusinessLogicController(new EFRepository())));
        }
    }
}
