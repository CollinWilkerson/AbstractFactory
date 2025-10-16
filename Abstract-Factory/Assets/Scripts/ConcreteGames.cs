using UnityEngine;

//inde
public class Ultrakill : IShooter
{
    public string GetBestGun()
    {
        return "Best Gun: Coin toss + revolver";
    }
    public Sprite GetCover()
    {
        return Resources.Load<Sprite>("ultrakill");
    }

}
//AAA
public class Titanfall : IShooter
{

    public string GetBestGun()
    {
        return "best gun: EVA-8 extended mag";
    }
    public Sprite GetCover()
    {
        return Resources.Load<Sprite>("tf2");
    }
}
//inde
public class Deltarune : IRPG
{
    public string GetBestCharacter()
    {
        return "Best Character: Ralsaei";
    }
    public Sprite GetCover()
    {
        return Resources.Load<Sprite>("Deltarune");
    }

}
//AAA
public class ClaireObscure : IRPG
{
    public string GetBestCharacter()
    {
        return "Best Character: Monocco";
    }
    public Sprite GetCover()
    {
        return Resources.Load<Sprite>("expedition33");
    }
}
//inde
public class CaveStory : IPlatformer
{
    public string GetBestLevel()
    {
        return "Best Level: The Outer Wall";
    }
    public Sprite GetCover()
    {
        return Resources.Load<Sprite>("cavestory");
    }

}
//AAA
public class Ratchet : IPlatformer
{
    public string GetBestLevel()
    {
        return "Best Level: Savali";
    }
    public Sprite GetCover()
    {
        return Resources.Load<Sprite>("rnc");
    }

}
