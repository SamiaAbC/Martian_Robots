using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Martian_Robots
{
    public partial class MarsForm : Form
    {
        public static class MarsClasses //UseInterface
        {
            public static int maxCoordinate = 50;
            public static int maxInstructions = 100;
            public static int[,] gridMarsSize;
            public static Scent scent = new Scent();
        }        
        public static Robot robot;
        public MarsForm()
        {
            InitializeComponent();
        }

        private void marsSizebtn_Click(object sender, EventArgs e)
        {
            string[] sizes = marsSize.Text.Split(' ');
            if (marsSize.Text != "" && isNumeric(sizes) && sizes.Count() == 2 && MaxCoordinates(sizes))
            {
                MarsClasses.gridMarsSize = new int[Int32.Parse(sizes[0]), Int32.Parse(sizes[1])];

                MessageBox.Show(MarsSizeString());
            }
            else
                badInput();
        }
        private void robotsInstructionsbtn_Click(object sender, EventArgs e)
        {
            if (MarsClasses.gridMarsSize == null) //Obliga a marcar primero el tamaño de Marte antes de situar/mover los robots
            {
                badInput();
            }
            else
            {                
                string[] instructions = robotsInstructions.Text.Split('\n');
                var i = 1;
                var firstLaneValid = true;
                foreach (var lane in instructions)
                {
                    if (i == 1)
                    {//TODO Method to control whitespaces & characters
                        firstLaneValid = lane.Count() > 4;
                        i++;
                    }
                    if (lane.Length <= MarsClasses.maxInstructions && firstLaneValid)
                    {
                        if (ContainsNumber(lane))
                        {
                            robot = CreateRobot(lane);
                        }
                        else
                        {
                            robot.Move(robot, lane);
                            string positionMsg = "The robot is in: " + robot.position[0].ToString() + " " + robot.position[1].ToString() + " " + robot.orientation;
                            if (robot.lost)                            
                                MessageBox.Show(positionMsg + " LOST");                            
                            else
                                MessageBox.Show(positionMsg);
                        }
                    }
                    else
                        badInput();
                }
            }
        }
        private void badInput()
        {
            VisibleInfoLabel();
            MessageBox.Show("Please, enter the information appropriately");            
        }
        public bool isNumeric(string[] sizes)
        {
            bool isNum = true;
            foreach(var number in sizes)
            {
                isNum = Regex.IsMatch(number, @"^\d+$");
                if (isNum == false)
                    return false;
            }
            return isNum;
        }
        private string MarsSizeString()
        {
            return "Mars size is : \n X --> " + MarsClasses.gridMarsSize.GetLength(0) + " \n Y --> " + MarsClasses.gridMarsSize.GetLength(1);
        }
        public int LineCount(string str)
        {
            return str.Split('\n').Length;
        }
        public bool ContainsNumber(string instruction) //Si la instrucción contiene números se trata de una colocación del robot
        {
            foreach (var letter in instruction.Split(' '))
            {
                if (Regex.IsMatch(letter, @"^\d+$"))
                    return true;
            }
            return false;
        }
             
        public bool MaxCoordinates (string[] sizes)
        {
            foreach (var size in sizes)
            {
                if (Convert.ToUInt16(size) > MarsClasses.maxCoordinate)
                    return false;
            }
            return true;
        }
        public Robot CreateRobot(string position)
        {
            Robot robot = new Robot();
            robot.position[0] = Convert.ToInt16(position.Split(' ')[0]);
            robot.position[1] = Convert.ToInt16(position.Split(' ')[1]);
            robot.orientation = Convert.ToChar(position.Split(' ')[2].FirstOrDefault());
            return robot;
        }
        public void VisibleInfoLabel()
        {
            label2.Visible = true;
            label3.Visible = true;
        }
    }       
}
