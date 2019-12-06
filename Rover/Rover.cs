using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Rover
{
    public class CoordinatePosition
    {
        public int x;
        public int y;

        public CoordinatePosition(int x1, int y2)
        {
            x = x1;
            y = y2;
        }
    }

    public class Rover
    {
        public GPS gps;

        public CoordinatePosition position;

        public Rover(int x1, int y2, Directions direction)
        {
            gps = new GPS(direction);
            position = new CoordinatePosition(x1, y2);
        }

        public void Scout(string commands)
        {
            foreach (var command in commands)
            {
                var commStr = command.ToString();
                if (string.Equals(commStr, "M")){
                    this.MoveForward();
                }
                else if (string.Equals(commStr, "R") || string.Equals(commStr, "L"))
                {
                    this.gps.GetNewFacingDirection(commStr);
                }
                else
                {
                    throw new Exception("wrong command");
                }
            }
        } 

        public CoordinatePosition MoveForward()
        {
            if (gps.currentFacingDirection == Directions.North)
            {
                position.y = position.y + 1;
            }
            else if (gps.currentFacingDirection == Directions.South)
            {
                position.y = position.y - 1;
            }
            else if (gps.currentFacingDirection == Directions.East)
            {
                position.x = position.x + 1;
            }
            else if(gps.currentFacingDirection == Directions.West)
            {
                position.x = position.x - 1;
            }
            else
            {
                throw new Exception("gps direction was neither north, south, east, or west and hence cannot be processed.");
            }
            return position;
        }
    }
}
