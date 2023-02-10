/*
    Interface Segregation Principle ISP states that clients should not be forced to implement interfaces they don't use.
    In a good system design, we should prefer using many small interfaces based on groups of methods, each one serving a submodule than using 
    one big interface.
    
    A good example in Damu's Article => https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
 */

Console.WriteLine("Hello, World!");

public interface ILead
{
   void CreateSubTask();
   void AssignTask();
   void WorkOnTask();
}
public class TeamLead : ILead
{
    public void AssignTask()
    {
        //Code to assign a task.
    }
    public void CreateSubTask()
    {
        //Code to create a sub task
    }
    public void WorkOnTask()
    {
        //Code to implement perform assigned task.
    }
}
public class Manager : ILead
{
    public void AssignTask()
    {
        //Code to assign a task.
    }
    public void CreateSubTask()
    {
        //Code to create a sub task.
    }
    public void WorkOnTask()
    {
        throw new Exception("Manager can't work on Task"); // So in this case the Manager class is forced to implement WorkOnTask method that does'n need.
    }
}



