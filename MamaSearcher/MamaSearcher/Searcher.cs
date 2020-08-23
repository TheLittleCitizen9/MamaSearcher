using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MamaSearcher
{
    public class Searcher : IMamaSearcher
    {
        public Dictionary<string, Action<int, string>> PatternsToAction { get; set; }

        public Searcher()
        {
            PatternsToAction = new Dictionary<string, Action<int, string>>();
        }
        public void PerformSearch(string content)
        {
            foreach (KeyValuePair<string, Action<int, string>> pair in PatternsToAction)
            {
                if(content.Contains(pair.Key))
                {
                    int index = PatternsToAction.Keys.ToList().IndexOf(pair.Key);
                    pair.Value.Invoke(index, pair.Key);
                }
            }
        }

        public void Subscribe(string pattern, Action<int, string> actionToPerform)
        {
            if(PatternsToAction.ContainsKey(pattern))
            {
                PatternsToAction[pattern] += actionToPerform;
            }
            else
            {
                PatternsToAction[pattern] = actionToPerform;
            }
            
        }
    }
}
