using System;


class Controls
{
    Movement movement = new Movement();
    Fire fire = new Fire();

    public void HandleInput(ConsoleKey key)
    {    
        switch (key)
        {
            case ConsoleKey.W:
                movement.moveUp();
                break;

            case ConsoleKey.X:
                movement.moveDown();
                break;

            case ConsoleKey.A:
                movement.moveLeft();
                break;

            case ConsoleKey.D:
                movement.moveRight();
                break;

            case ConsoleKey.Q:
                movement.moveUpDiagonalLeft();
                break;

            case ConsoleKey.E:
                movement.moveUpDiagonalRight();
                break;

            case ConsoleKey.Z:
                movement.moveDownDiagonalLeft();
                break;

            case ConsoleKey.C:
                movement.moveDownDiagonalright();
                break;

            case ConsoleKey.Spacebar:
                fire.fire();
                break;   

        }
    }    
}