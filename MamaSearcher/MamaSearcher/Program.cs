using System;

namespace MamaSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Searcher searcher = new Searcher();
            SearchActions searchActions = new SearchActions();
            searcher.Subscribe("abc", searchActions.PrintPattern);
            searcher.Subscribe("abc", searchActions.PrintPattern2);
            searcher.Subscribe("def", searchActions.PrintPattern);
            searcher.PerformSearch("abcdefg");
        }
    }
}
