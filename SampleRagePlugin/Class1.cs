using System;
using System.Windows.Forms;
using Rage;

[assembly: Rage.Attributes.Plugin("My First Plugin", Description = "This is my first plugin.", Author = "MyName")]

namespace SampleRagePlugin
{
    public class EntryPoint
    {
        public static void Main()
        {
            while (true)
            {
                if (Game.IsKeyDown(Keys.NumPad7))
                {
                    Game.DisplayNotification("The ~b~key ~w~has been pressed");
                }
                
                GameFiber.Yield();
            }
        }
    }
}