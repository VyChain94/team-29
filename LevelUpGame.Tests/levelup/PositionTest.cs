using NUnit.Framework;
using levelup;

[TestFixture]



public class PositionTest {
Point p;
Position pos;


    [SetUp]
    public void SetUp(){
        p = new Point(0,1);
        pos = new Position(p);

    }
    
    [Test]
public void TestNewPosition()
{
    Point t = new Point(0,1);
    Position pos1 = new Position(t);
    int x1 = t.X;
    int x2 = p.X;
    int y1 = t.Y;
    int y2 = p.Y;
Assert.AreEqual(x2, x1);
Assert.AreEqual(y2, y1);

}
}