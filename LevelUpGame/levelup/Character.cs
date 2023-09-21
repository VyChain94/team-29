public class Character{

    string name;
    GameMap map;

    public Character() {
        this.name = "Character";
    }

    public Character(string name) {
        this.name = name;
    }

    public string getName() {
        return this.name;
    }

    public void enterMap(GameMap map){
        this.setMap(map);
    }

    public GameMap getMap() {
        return this.map;
    }

    public void setMap(GameMap m) {
        this.map = m;
    }

    public Point getPosition() {
        return new Point(0,0);
    }
}