// orientate tank object based on what key is pressed



public class Orientate
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
        UpLeft,
        UpRight,
        DownLeft,
        DownRight
    }
    public Direction currentDirection {get; set; }

}