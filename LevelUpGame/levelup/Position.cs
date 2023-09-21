
using static levelup.GameController;

public class Position
{
Point point;
public Position(Point p){
    point = p;
}


    static Point getPositionFromDirection(DIRECTION direction, int steps = 1)
    {


        switch (direction)
        {
            // NORTH, SOUTH, EAST, WEST
            case DIRECTION.NORTH:
                return new Point(steps, 0);


            case DIRECTION.SOUTH:
                return new Point(steps * -1, 0);


            case DIRECTION.EAST:
                return new Point(0, steps);


            case DIRECTION.WEST:
                return new Point(0, steps * -1);


            default:
                return new Point(0, 0);



        }

    }
}