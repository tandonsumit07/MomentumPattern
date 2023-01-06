using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class EditorState
    {
        private readonly string Content;

        public EditorState(string content)
        {
            Content = content;
        }

        public string GetContent()
        {
            return Content;
        }
    }
}
