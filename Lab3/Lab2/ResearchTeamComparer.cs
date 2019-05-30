using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ResearchTeamComparer : IComparer<ResearchTeam>
    {
        public int Compare(ResearchTeam x, ResearchTeam y)
        {
            if (x.Papers.Count > y.Papers.Count)
                return 1;
            else if (x.Papers.Count < y.Papers.Count)
                return -1;
            return 0;
        }
    }
}
