using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_05
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        public List<string> Components = ["rotor1", "rotor2", "rotor3", "rotor4"];
        public List<string> GetComponents()
        { 
            return Components; 
        }
        public void Charge()
        {
            Console.Write("Charging ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine("100%\nCharged!");
        }

        public string GetInfo()
        {
            return "Xiaomi MiTu Minidrone 720P";
        }

        string IChargeable.GetInfo()
        {
            return "Battery Level: 25%";
        }

        string IFlyingRobot.GetRobotType()
        {
            return "Quadcopter";
        }


        
           
        
    }
}
