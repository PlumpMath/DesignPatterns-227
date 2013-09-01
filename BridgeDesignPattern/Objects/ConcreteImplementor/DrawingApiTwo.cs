﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BridgeDesignPattern.Objects.Implementor;

namespace BridgeDesignPattern.Objects.ConcreteImplementor
{
    public class DrawingApiTwo: IDrawingApi
    {
        public void DrawCircle(double x, double y, double radius)
        {
            Console.WriteLine("API2.Circle: at {0}:{1} radius {2}", x, y, radius);
        }
    }
}
