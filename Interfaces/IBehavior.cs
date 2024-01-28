using Project1A.Core;


namespace Project1A.Interfaces
{
    public interface IBehavior
    {
        bool Act(Monster monster, CommandSystem commandSystem);
    }
}
