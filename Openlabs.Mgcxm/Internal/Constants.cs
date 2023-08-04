// Copr. (c) Nexus 2023. All rights reserved.

namespace Openlabs.Mgcxm.Internal;

public static class Constants
{
    public static void Initialize()
    {
        CurrentScheduler = ActionScheduler.Create("Main Scheduler");
    }
    
    public static ActionScheduler CurrentScheduler { get; private set; } = null!;
}