using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiMainMenuManager : Singleton<UiMainMenuManager>
{
    public void _BT_ChangeModel(int Value)
    {
        MainMenuManager.instance.ChangeModel(Value);
    }

    public void _BT_ChangeIndexGun(int Value)
    {
        MainMenuManager.instance.ChangeIndexPosGun(Value);
    }

    public void _BT_CHangeGunType(int Value)
    {
        MainMenuManager.instance.ChangeGunType(Value);
    }
}
