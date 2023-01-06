using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern
{
    public class History
    {
        private List<EditorState> states = Enumerable.Empty<EditorState>().ToList();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState Pop()
        {
            int lastStateIndex = states.Count;
            states.RemoveAt(lastStateIndex-1);
            return states.LastOrDefault();

        }
    }
}
