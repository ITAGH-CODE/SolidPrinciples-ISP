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
}

public interface IDeveloper
{
    void WorkOnTask();
}
public class Developer : IDeveloper
{
    public void WorkOnTask()
    {
        throw new NotImplementedException();
    }
}
public class TeamLead : ILead , IDeveloper
{
    public void AssignTask()
    {
        // Code to assign a task.
    }
    public void CreateSubTask()
    {
        // Code to create a sub task
    }
    public void WorkOnTask()
    {
        // Code to work on task
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
}

// Now, Manager class has only methods that it needs. We are not forced to create any other method that a class doesn't use. => ISP respected



