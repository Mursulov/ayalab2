using System;
using Xunit;
using HomeworkLib;

namespace HomeworkLib.Tests
{
    public class VehicleTests
    {
        [Fact]
        public void Plane_CorrectFields()
        {
            var p = new Plane(1,2,1000,200,2020,1200,10);
            Assert.Equal(1200, p.Height);
            Assert.Equal(10, p.Passengers);
        }

        [Fact]
        public void Ship_CorrectFields()
        {
            var s = new Ship(0,0,500,50,2022,100,"Port");
            Assert.Equal(100, s.Passengers);
            Assert.Equal("Port", s.Port);
        }
    }
}
