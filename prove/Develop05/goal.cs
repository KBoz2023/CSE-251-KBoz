


using System.Runtime.CompilerServices;

abstract class Goal
{
    private bool completed;
    private string goalName;
    private int points;
    private string goalType;



    public Goal(bool completed, string goalName, int points, string goalType)
    {
        this.completed = completed;
        this.goalName = goalName;
        this.points = points;
        this.goalType = goalType;
    }
    
}