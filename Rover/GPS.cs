using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Rover
{
    public enum Directions
    {
        North = 0,
        West = 1,
        South = 2,
        East = 3
    }

    public class GPS 
    {

        public Directions currentFacingDirection;

        public GPS(Directions initialFacingDirection)
        {
            currentFacingDirection = initialFacingDirection;
        }
        
        public Directions GetNewFacingDirection(string leftRightMovement)
        {
            
            if(Equals(leftRightMovement, "L"))
            {
                if((int)currentFacingDirection == 3)
                {
                    currentFacingDirection = 0;
                }
                else
                {
                    currentFacingDirection = currentFacingDirection + 1;
                }
            }
            else if(Equals(leftRightMovement, "R"))
            {
                if(currentFacingDirection == 0)
                {
                    currentFacingDirection = Directions.East;
                }
                else
                {
                    currentFacingDirection = currentFacingDirection - 1;
                }
            }
            else
            {
                throw new Exception("Movement is neither Right or Left, cannot be processed.");
            }
            return currentFacingDirection;
        }
    }
}
