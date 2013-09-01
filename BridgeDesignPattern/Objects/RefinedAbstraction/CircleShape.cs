using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BridgeDesignPattern.Objects.Abstraction;
using BridgeDesignPattern.Objects.Implementor;

namespace BridgeDesignPattern.Objects.RefinedAbstraction
{
    public class CircleShape : Shape
    {
        private double x, y, radius;

        public CircleShape(double x, double y, double radius, IDrawingApi drawingApi)
            : base (drawingApi)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawingApi.DrawCircle(x, y, radius);
        }

        public override void ResizeByPercentage(double pct)
        {
            radius *= pct;
        }
    }
}
