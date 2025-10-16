using UnityEngine;

public enum GameType
{
    none,
    Shooter,
    RPG,
    Platformer
}

public interface IGame
{
    public Sprite GetCover();
}

public interface IShooter : IGame
{
    public string GetBestGun();
}

public interface IRPG : IGame
{
    public string GetBestCharacter();
}

public interface IPlatformer : IGame
{
    public string GetBestLevel();
}
