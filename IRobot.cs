using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace HomeWork_Basic_05
{
    public interface IRobot
    {
        string GetInfo();
        public List<string> GetComponents();
        string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
