using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppMultiTool.Utils
{
    public class MatchList : IEnumerable<Match>
    {
        private List<Match> matches = new();
        public void Add(Match match) => matches.Add(match);
        public IEnumerator<Match> GetEnumerator() => matches.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static MatchList ConvertBy(MatchCollection _matches)
        {
            MatchList matches = new();
            foreach (Match match in _matches)
            {
                matches.Add(match);
            }
            return matches;
        }

        public void ForEach(Action<Match> action)
        {
            foreach (var item in matches)
            {
                action(item);
            }
        }
    }
}
