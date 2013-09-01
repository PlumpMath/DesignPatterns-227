using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeDesignPattern.Objects.Implementor
{
    public interface IDrawingApi
    {
        void DrawCircle(double x, double y, double radius);
    }
}
