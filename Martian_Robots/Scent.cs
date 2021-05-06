using System;
using System.Collections.Generic;

namespace Martian_Robots
{
    public class Scent
    {
        public List<int> pos1 = new List<int>();
        public List<int> pos2 = new List<int>();
        public List<char> orientation = new List<char>();
    
        public void AddScentPosition (int pos1, int pos2, char orientation) //Guarda el 'aroma' por donde se perdió el robot
        {
            this.pos1.Add(pos1);
            this.pos2.Add(pos2);
            this.orientation.Add(orientation);
        }
        public bool AnyScent(Robot robot) //Comprueba si existe algún 'aroma' en su posición
        {
            if (this.pos1.Contains(robot.position[0]) &&
                this.pos2.Contains(robot.position[1]) &&
                this.orientation.Contains(robot.orientation))
                return true;
            return false;
        }
    }
}
