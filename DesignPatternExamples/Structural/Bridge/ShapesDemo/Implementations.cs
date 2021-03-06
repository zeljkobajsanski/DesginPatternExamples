﻿namespace DesignPatternExamples.Structural.Bridge.ShapesDemo
{
    public interface IColor
    {
        string Paint();
    }

    public class BlackColor : IColor {
        public string Paint()
        {
            return "black";
        }
    }

    public class WhiteColor : IColor {
        public string Paint()
        {
            return "white";
        }
    }
}