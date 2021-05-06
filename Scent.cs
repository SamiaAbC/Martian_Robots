using System;
using static Martian_Robots.Mars;


namespace Martian_Robots
{
    public class Scent
    {
        public int pos1;
        public int pos2;
        public char orientation;
    
        public void SaveScentPosition (Scent scent, int pos1, int pos2, char orientation)
        {
            scent.pos1 = pos1;
            scent.pos2 = pos2;
            scent.orientation = orientation;
        }
    }
}
