using Microsoft.VisualStudio.TestTools.UnitTesting;
using Martian_Robots;
using System.Linq;

namespace Martian_RobotsTests
{
    [TestClass]
    public class UnitTest1
    {   
        [TestMethod]
        public void AnyScentTest()
        {
            //Arrange      
            Scent scent = new Scent();
            scent.pos1.Add(5);
            scent.pos2.Add(3);
            scent.orientation.Add('N');

            Robot robot = new Robot();
            robot.position[1] = 3;
            robot.position[0] = 5;
            robot.orientation = 'N';            

            bool expected = true;
            //Act
            var result = scent.AnyScent(robot);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AnyScentFailedTest()
        {
            //Arrange                  
            Scent scent = new Scent();
            scent.pos1.Add(5);
            scent.pos2.Add(3);
            scent.orientation.Add('S');

            Robot robot = new Robot();
            robot.position[1] = 3;
            robot.position[0] = 5;
            robot.orientation = 'N';

            bool expected = false;
            //Act
            var result = scent.AnyScent(robot);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void AddScentPositionTest()
        {
            //Arrange                  
            Scent scent = new Scent();
            int pos1 = 3;
            int pos2 = 4;
            char orientation = 'E';
            var firstPos1 = scent.pos1.Count();
            var firstPos2 = scent.pos1.Count();
            var firstOrientation = scent.orientation.Count();

            //Act
            scent.AddScentPosition(pos1,pos2,orientation);
            var actualPos1 = scent.pos1.Count();
            var actualPos2 = scent.pos1.Count();
            var actualOrientation = scent.orientation.Count();
            //Assert
            Assert.IsTrue(
                actualPos1> firstPos1 &&
                actualPos2 > firstPos2 &&
                actualOrientation  > firstOrientation);
        }
    }
}
