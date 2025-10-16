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
        return new Ultrakill();
    }
    public IRPG SelectRPG()
    {
        return new Deltarune();
    }
    public IPlatformer SelectPlatformer()
    {
        return new CaveStory();
    }
}

public class AAAFactory: AbstractFactory
{
    public IShooter SelectShooter()
    {
        return new Titanfall();
    }
    public IRPG SelectRPG()
    {
        return new ClaireObscure();
    }
    public IPlatformer SelectPlatformer()
    {
        return new Ratchet();
    }
}
