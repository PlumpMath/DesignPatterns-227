using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadePattern.Objects.ComplexParts;

namespace FacadePattern.Objects.Facade
{
    public class Computer
    {
        private CPU processor;
        private Memory ram;
        private HardDrive hd;

        private const long BOOT_ADDRESS = 0;
        private const long BOOT_SECTOR = 2;
        private const int SECTOR_SIZE = 4;

        public Computer()
        {
            this.processor = new CPU();
            this.ram = new Memory();
            this.hd = new HardDrive();
        }

        public void start()
        {
            processor.Freeze();
            ram.load(BOOT_ADDRESS, hd.Read(BOOT_SECTOR, SECTOR_SIZE));
            processor.Jump(BOOT_ADDRESS);
            processor.Execute();
        }

        public void Shutdown()
        {
        }
    }
}
