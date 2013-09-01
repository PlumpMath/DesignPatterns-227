using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern.Objects.ComplexParts
{
    public class HardDrive
    {
        public byte[] Read(long lba, int size) {
            var b = new List<byte>();
            return b.ToArray();
        }
    }
}
