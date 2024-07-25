using System;
using System.Windows.Markup;


class Controls
{
    public Movement movement = new Movement();
    // public Bullet bullet = new Bullet();
    public Orientate orientate = new Orientate();
    
    

    public void HandleInput(Keys key)
    {    
        switch (key)
        {
            case Keys.W:
                movement.moveUp();
                orientate.currentDirection = Orientate.Direction.Up;
                break;

            case Keys.X:
                movement.moveDown();
                orientate.currentDirection = Orientate.Direction.Down;
                break;

            case Keys.A:
                movement.moveLeft();
                orientate.currentDirection = Orientate.Direction.Left;
                break;

            case Keys.D:
                movement.moveRight();
                orientate.currentDirection = Orientate.Direction.Right;
                break;

            case Keys.Q:
                movement.moveUpDiagonalLeft();
                orientate.currentDirection = Orientate.Direction.UpLeft;
                break;

            case Keys.E:
                movement.moveUpDiagonalRight();
                orientate.currentDirection = Orientate.Direction.UpRight;
                break;

            case Keys.Z:
                movement.moveDownDiagonalLeft();
                orientate.currentDirection = Orientate.Direction.DownLeft;
                break;

            case Keys.C:
                movement.moveDownDiagonalRight();
                orientate.currentDirection = Orientate.Direction.DownRight;
                break;

            case Keys.S:
                
                break;   


        }

    }    
}