﻿using SFML.Audio;
using SFML.Window;
using SFML.Graphics;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
//using ProjectStellar.FormLauncher;

namespace ProjectStellar
{
   public class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLauncher.Launcher _launcher = new FormLauncher.Launcher();
            Application.Run(_launcher);

          
            Game Game = new Game(0, _launcher.Settings.Resolution, _launcher.Settings.IsFullScreen);
            Game.Run();
            
        }
    }
}
