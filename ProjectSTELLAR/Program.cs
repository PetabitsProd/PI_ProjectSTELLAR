﻿using SFML.Audio;
using SFML.Window;
using SFML.Graphics;
using System;

namespace ProjectStellar
{
    class Program
    {
        static void Main(string[] args)
        {
            Game Game = new Game();
            Game.Run();
            //RenderWindow window = new RenderWindow(new VideoMode(1200, 600), "Project STELLAR");
            //Menu menu = new Menu(1080, 720);

            //while (window.IsOpen)
            //{

                
            //    window.Display();
            //}
           

        }
    }
}