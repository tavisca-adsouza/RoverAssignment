using MarsRover.Rover;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rover rover = new Rover(0, 0, Directions.North);
            rover.Scout("MMM");
            rover.position.x.Equals(0);
            rover.position.y.Equals(3);
            rover.gps.currentFacingDirection.Equals(Directions.North);
        }

        [Fact]
        public void Test2()
        {
            Rover rover = new Rover(0, 1, Directions.East);
            rover.Scout("MML");
            rover.position.x.Equals(2);
            rover.position.y.Equals(1);
            rover.gps.currentFacingDirection.Equals(Directions.North);
        }

        [Fact]
        public void Test3()
        {
            Rover rover = new Rover(10, 5, Directions.North);
            rover.Scout("MMLMRMML");
            rover.position.x.Equals(9);
            rover.position.y.Equals(9);
            rover.gps.currentFacingDirection.Equals(Directions.West);
        }

         
    }
}
