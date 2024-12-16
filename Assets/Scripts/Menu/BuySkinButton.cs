using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuySkinButton : MonoBehaviour
{
    public ShopManager shopmanager;
    public Score score;
    public DisplayPerls displayperls;
    public static int ActualSkinPrice;
    public static int ActualSkinIndex;
    [SerializeField] GameObject PurchaseCompleted;

    public void BuySkin()
    {
        if(DisplayPerls.Perls >= ActualSkinPrice)
        {
            Score.Perls = Score.Perls - ActualSkinPrice;
            score.SaveGame();
            shopmanager.UnlockSkin(ActualSkinIndex);
            PurchaseCompleted.SetActive(true);
            displayperls.ResetDisplayPerls();
            this.gameObject.SetActive(false);
        }
    }
}
