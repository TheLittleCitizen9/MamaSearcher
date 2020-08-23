using System;
using System.Collections.Generic;
using System.Text;

namespace MamaSearcher
{
    public class SearchActions
    {
        public Searcher Searcher = new Searcher();
        public void PrintPattern(int index, string pattern)
        {
            Console.WriteLine($"The pattern is: {pattern}, in index: {index}");
        }
    }
}
