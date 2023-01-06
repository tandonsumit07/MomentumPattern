using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{
    public class Editor
    {
        private string Content;

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string content)
        {
            Content = content;
        }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.GetContent();
        }
    }
}
