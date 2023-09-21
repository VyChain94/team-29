using NUnit.Framework;
using levelup;

public class CharacterTest {
    Character chr;

    [SetUp]
    public void SetUp(){
        chr = new Character();
    }

    [Test]
    public void TestDefaultName() {        
        string name = chr.getName();
        string defaultname = "Character";
        Assert.AreEqual(defaultname,name);
    }

    [Test]
    public void TestCustomName() {
        chr = new Character("Bob");
        string name = chr.getName();
        string customName = "Bob";
        Assert.AreEqual(customName, name);
    }
}