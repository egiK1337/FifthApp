﻿

namespace FifthApp
{
    public interface IRobot
    {
        public string GetInfo();
        public List<string> GetComponents();
        public string GetRobotType()
        {
            return "I am a simple robot";
        }
    }
}
