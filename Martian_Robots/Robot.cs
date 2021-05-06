using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Martian_Robots.MarsForm;

namespace Martian_Robots
{
    public class Robot
    {
        public char orientation;
        public int[] position = new int[2];
        public bool lost = false;
        
        public void Move(Robot robot, string movement)
        {
            string[] movementLetters = movement.Split(' ');
            foreach (var move in movementLetters)
            {
                CardinalPointOrientation(robot, Convert.ToChar(move.FirstOrDefault()));
                if (robot.lost)
                    return;
            }
        }

        static void CardinalPointOrientation(Robot robot, char newOrientation) //Modifica la orientación del robot y lo mueve
        {            
            List<char> cardinalPointsList = new List<char> { 'N', 'E', 'S', 'W' };

            if (newOrientation == 'R')
            {
                if (robot.orientation != 'W')
                    robot.orientation = cardinalPointsList[cardinalPointsList.IndexOf(robot.orientation) + 1];
                else
                    robot.orientation = 'N';
            }
            else if (newOrientation == 'L')
            {
                if (robot.orientation != 'N')
                    robot.orientation = cardinalPointsList[cardinalPointsList.IndexOf(robot.orientation) - 1];
                else
                    robot.orientation = 'W';
            }
            else if (newOrientation == 'F')
            {
                if (MarsClasses.scent.AnyScent(robot))                
                    return;
                
                switch (robot.orientation)
                {
                    case 'N':
                        robot.position[1] = robot.position[1] + 1;
                        if (RobotOutGrid(robot))
                        {
                            robot.position[1] = robot.position[1] - 1;
                            RobotIsLost(robot);
                        }                            
                        break;
                    case 'E':
                        robot.position[0] = robot.position[0] + 1;
                        if (RobotOutGrid(robot))
                        {
                            robot.position[0] = robot.position[1] - 1;
                            RobotIsLost(robot);
                        }                                                  
                        break;
                    case 'S':
                        robot.position[1] = robot.position[1] - 1;
                        if (RobotOutGrid(robot))
                        {
                          robot.position[1] = robot.position[1] + 1;
                            RobotIsLost(robot);
                        }
                        break;
                    case 'W':
                        robot.position[0] = robot.position[0] - 1;
                        if (RobotOutGrid(robot))
                        {
                            robot.position[1] = robot.position[0] + 1;
                            RobotIsLost(robot);
                        }
                        break;
                }
            }           
        }
        static void RobotIsLost(Robot robot) //Asigna al robot la característica de perdido y guarda la posición de su 'aroma'
        {            
            MarsClasses.scent.AddScentPosition(robot.position[0], robot.position[1], robot.orientation); 
            robot.lost = true;
        }
        static bool RobotOutGrid(Robot robot) //Comprueba si el robot está fuera de Marte
        {
            if (robot.position[0] > MarsClasses.gridMarsSize.GetLength(0) || 
                robot.position[1] > MarsClasses.gridMarsSize.GetLength(1) ||
                robot.position[0] < 0 ||
                robot.position[1] < 0)
                return true;
            return false;
        }              
    }
}
