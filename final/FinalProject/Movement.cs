// class for moving and aiming


// qweadzxc movement


public class Movement
{
    private int playerSpeed = 5;
    private float angle = 45;
    public Point playerPosition = new Point(500, 500);
    public void moveUp()
    {
        playerPosition.Y -= playerSpeed;
    }
    public void moveLeft()
    {
        playerPosition.X -= playerSpeed;
    }

    public void moveRight()
    {
        playerPosition.X += playerSpeed;
    }
    public void moveDown()
    {
       playerPosition.Y += playerSpeed;
    }

    public void moveUpDiagonalLeft()
    {
        playerPosition.Y -= playerSpeed;
        playerPosition.X -= playerSpeed;
    }
    public void moveUpDiagonalRight()
    {
        playerPosition.Y -= playerSpeed;
        playerPosition.X += playerSpeed;
    }
    public void moveDownDiagonalLeft()
    {
        playerPosition.X -= playerSpeed;
        playerPosition.Y += playerSpeed;
    }
    public void moveDownDiagonalRight()
    {
        playerPosition.X += playerSpeed;
        playerPosition.Y += playerSpeed;
    }

}