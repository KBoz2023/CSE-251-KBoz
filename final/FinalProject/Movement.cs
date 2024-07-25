// class for moving and aiming


// qweadzxc movement

using System.Runtime.CompilerServices;

public class Movement{
    private int playerPositionX;
    private int playerPositionY;
    public void moveUp()
    {
        playerPositionY += 1;
    }
    public void moveLeft()
    {
        playerPositionX -= 1;
    }

    public void moveRight()
    {
        playerPositionX += 1;
    }
    public void moveDown()
    {
       playerPositionY -= 1;
    }

    public void moveUpDiagonalLeft()
    {
        playerPositionY += 1;
        playerPositionX -= 1;
    }
    public void moveUpDiagonalRight()
    {
        playerPositionY += 1;
        playerPositionX += 1;
    }
    public void moveDownDiagonalLeft()
    {
        playerPositionX -= 1;
        playerPositionY -= 1;
    }
    public void moveDownDiagonalright()
    {
        playerPositionX += 1;
        playerPositionY -= 1;
    }
}