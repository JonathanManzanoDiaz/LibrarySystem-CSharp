using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem.Menus
{
    public class Menu
    {
        private string Prompt;
        private string[] Options;
        private int SelectedIndex;
        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }

        public void DisplayOptions()
        {
            Console.WriteLine(@" __    _ _                      _____         _             
|  |  |_| |_ ___ ___ ___ _ _   |   __|_ _ ___| |_ ___ _____ 
|  |__| | . |  _| .'|  _| | |  |__   | | |_ -|  _| -_|     |
|_____|_|___|_| |__,|_| |_  |  |_____|_  |___|_| |___|_|_|_|
                        |___|        |___|                  ");
            Console.WriteLine("\n------------------------------------------------------------\n");
            string prefix = " *";
            for(int i = 0; i<Options.Length; i++)
            {
                if(i == SelectedIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine($"{prefix} {Options[i]}");
                } else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"   {Options[i]}");
                }
            }
            Console.ResetColor();
            Console.WriteLine();
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            Console.CursorVisible = true;
            return SelectedIndex;

        }
    }
}
