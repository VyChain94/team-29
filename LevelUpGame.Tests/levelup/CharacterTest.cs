using NUnit.Framework;
using levelup;
//using levelup.GameController;

public class CharacterTest
{
    Character chr;
    GameMap map;
    Point startPos;
    levelup.GameController.DIRECTION direction;

    [SetUp]
    public void SetUp()
    {
        chr = new Character();
        map = new GameMap();
        startPos = new Point(0, 0);
        //direction = new DIRECTION();
    }

    [Test]
    public void TestDefaultName()
    {
        string name = chr.getName();
        string defaultname = "Character";
        Assert.AreEqual(defaultname, name);
    }

    [Test]
    public void TestCustomName()
    {
        chr = new Character("Bob");
        string name = chr.getName();
        string customName = "Bob";
        Assert.AreEqual(customName, name);
    }

    [Test]
    public void TestEnterMap()
    {
        chr.enterMap(map);
        // Test map existence 
        // test starting point
        GameMap chrMap = chr.getMap();
        Point chrPos = chr.getPosition();
        int chrX = chrPos.X;
        int chrY = chrPos.Y;
        Assert.AreEqual(map, chrMap);
        Assert.AreEqual(startPos.X, chrX);
        Assert.AreEqual(startPos.Y, chrY);
    }

    [Test]
    public void TestMove()
    {

    }
}