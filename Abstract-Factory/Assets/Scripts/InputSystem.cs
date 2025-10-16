using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputSystem : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI flavor;
    [SerializeField] Image cover;
    [SerializeField] TMP_Dropdown genreDropdown;

    GameType gameType = GameType.none;
    AbstractFactory factory;

    public void OnTypeChange()
    {
        switch (genreDropdown.value)
        {
            case 0:
                return;
            case 1:
                gameType = GameType.Shooter;
                break;
            case 2:
                gameType = GameType.RPG;
                break;
            default:
                gameType = GameType.Platformer;
                break;
        }
        CheckDisplay();
    }

    public void OnSelectFactory(int type)
    {
        switch (type)
        {
            case 0:
                factory = new AAAFactory();
                break;
            case 1:
                factory = new IndeFactory() ;
                break;
        }
        CheckDisplay();
    }

    private void CheckDisplay()
    {
        if (factory == null)
        {
            return;
        }
        if (gameType == GameType.Shooter)
        {
            IShooter shooter = factory.SelectShooter();
            cover.sprite = shooter.GetCover();
            flavor.text = shooter.GetBestGun();
            return;
        }
        if (gameType == GameType.RPG)
        {
            IRPG rpg = factory.SelectRPG();
            cover.sprite = rpg.GetCover();
            flavor.text = rpg.GetBestCharacter();
            return;
        }
        if (gameType == GameType.Platformer)
        {
            IPlatformer platformer = factory.SelectPlatformer();
            cover.sprite = platformer.GetCover();
            flavor.text = platformer.GetBestLevel();
            return;
        }
    }
}
