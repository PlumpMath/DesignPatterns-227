using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BridgeDesignPattern.Objects.Implementor;

namespace BridgeDesignPattern.Objects.Abstraction
{
    public abstract class Shape
    {
        protected IDrawingApi drawingApi;
        protected Shape(IDrawingApi drawingApi)
        {
            this.drawingApi = drawingApi;
        }

        public abstract void Draw();
        public abstract void ResizeByPercentage(double pct);
    }
}
