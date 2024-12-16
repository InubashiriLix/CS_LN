using System;

namespace namespace_callback_button
{
    public delegate void ButtonClickHandler();

    public class Button
    {
        public event ButtonClickHandler? OnClick;

        public void Click()
        {
            OnClick?.Invoke();
        }
    }

    public class Program
    {
        public static void main()
        {
            Button button = new Button();
            button.OnClick += () => Console.WriteLine("ButtonClicked");
            button.Click();
        }
    }
}
