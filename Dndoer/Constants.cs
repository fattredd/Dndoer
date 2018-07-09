using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dndoer
{
    public class DB
    {
        public DB()
        {
            // Attrs                           Ac An Ar At De Hi In In In Me Na Pe Pe Pe Re Sl St Su
            RaceSkills.Add("Human", new int[] { 0, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 2 });
        }

        public Dictionary<string, int[]> RaceSkills;

    }
}