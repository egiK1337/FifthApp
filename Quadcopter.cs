
namespace FifthApp
{
    public class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> list_components = new List<string>() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public string GetRobotType()
        {
            return "type of robot - quadrocopter";
        }
        public void Charge() 
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
        public string GetInfo()
        {
            return "This is a flying robot";
        }      
        public List<string> GetComponents()
        {           
            return list_components;
        }
    }
}
