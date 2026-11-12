namespace SpaceAcademy;

public static class LaunchPolicy
{
    public static bool CanLaunch(int fuel, bool safetyApproved)
    {
        bool canLaunch = fuel >= 50 && safetyApproved;
        return canLaunch;
    }
}
