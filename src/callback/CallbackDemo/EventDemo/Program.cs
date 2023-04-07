using System;
using System.Diagnostics;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            button.Clicked += Button_Clicked;

            Console.WriteLine("Press to enter to fire the button click event ....");
            Console.ReadLine();

            button.OnClicked();
        }

        static void Button_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button clicked!");
        }
    }

    class Button
    {
        // declaration of an event in the Button class. The event is of type EventHandler, which is a predefined delegate type in C#
        // that represents an event handler method that does not have any arguments.
        
        public event EventHandler Clicked;

        public void OnClicked()
        {
            if (Clicked != null)
            {
                //this is the sender object that raises the event, which in this case is an instance of the Button class
                Clicked(this, EventArgs.Empty);
            }
        }
    }

}

// Output:
// Press to enter to fire the button click event ....
// Button clicked!