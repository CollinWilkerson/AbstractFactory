using UnityEngine;

public interface AbstractFactory
{
    public IShooter SelectShooter();
    public IRPG SelectRPG();
    public IPlatformer SelectPlatformer();
}

public class IndeFactory: AbstractFactory
{
    public IShooter SelectShooter()
    {
        return null;
    }
    public IRPG SelectRPG()
    {
        return null;
    }
    public IPlatformer SelectPlatformer()
    {
        return null;
    }
}

public class AAAFactory: AbstractFactory
{
    public IShooter SelectShooter()
    {
        return null;
    }
    public IRPG SelectRPG()
    {
        return null;
    }
    public IPlatformer SelectPlatformer()
    {
        return null;
    }
}
