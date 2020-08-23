using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public class Searcher : IMamaSearcher
    {
        public Dictionary<string, Action<int, string>> PatternsToAction { get; set; }
        public List<string> Patterns { get; set; }
        public void PerformSearch(string content)
        {
            foreach (KeyValuePair<string, Action<int, string>> pair in PatternsToAction)
            {
                if(content.Contains(pair.Key))
                {
                    int index = Patterns.IndexOf(pair.Key);
                    pair.Value.Invoke(index, pair.Key);
                }
            }
        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            Patterns.Add(pattern);
            PatternsToAction[pattern] = actionToPerform;
        }
    }
}
