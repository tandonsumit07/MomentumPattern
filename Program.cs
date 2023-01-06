
using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            History history = new History();

            editor.SetContent("a");
            history.Push(editor.CreateState());

            editor.SetContent("b");
            history.Push(editor.CreateState());

            editor.SetContent("c");
            history.Push(editor.CreateState());

            editor.Restore(history.Pop());

            Console.WriteLine("Hello World!" + editor.GetContent());
        }
    }
}
