namespace FifthApp
{
    internal class Program
    {
        static void Main()
        {
            Quadcopter quadcopter = new Quadcopter();
            var getComponents = quadcopter.GetComponents();
            var getInfo = quadcopter.GetInfo();
            var getRobotType = quadcopter.GetRobotType();
            quadcopter.Charge();
        }
    }
}