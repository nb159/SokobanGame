namespace libs;

public class Box : GameObject {
    
    private GameObjectFactory gameObjectFactory;
    // private int targetsLeft;
 
    public Map map = GameEngine.Instance.GetMap();
    public Box () : base(){
        this.gameObjectFactory = (GameEngine.Instance.gameObjectFactory as GameObjectFactory);
            Type = GameObjectType.Player;
            CharRepresentation = '○';
            Color = ConsoleColor.DarkGreen;
    }
    

    public override void Move(int dx, int dy) {
        var engine = GameEngine.Instance;

        bool touched = false;
        int  goToX = PosX +dx;
        int  goToY = PosY +dy;
        
        this.SetPrevPosY(this.PosY);
        this.SetPrevPosX(this.PosX);
        this.PosX += dx;
        this.PosY += dy;
    }
}