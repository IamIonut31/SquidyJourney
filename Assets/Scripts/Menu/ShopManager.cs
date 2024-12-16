using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public static int currentskinindex = 0;
    public bool[] squidskins;
    public GameObject[] SelectButtons;
    public TextMeshProUGUI[] SelectText;
    public TextMeshProUGUI displayindex;

    private void Start()
    {
        LoadSkins();
        for(int i=0; i<=11; i++)
        {
            if(squidskins[i] == true)
            {
                SelectButtons[i].SetActive(true);
                SelectText[i].text = "Owned";
                if(currentskinindex == i)
                {
                    SelectText[i].text = "Selected";
                }
            }
            else
            {
                SelectButtons[i].SetActive(false);
            }
        }
    }

    public void UnlockSkin(int Index)
    {
        squidskins[Index] = true;
        SelectText[Index].text = "Owned";
        SaveSystem.SaveSkins(this);
        SelectButtons[Index].SetActive(true);
    }

    public void LockSkin()
    {
        for(int i=0; i<=11; i++)
        {
            squidskins[i] = false;
        }
        SaveSystem.SaveSkins(this);
    }

    public void LoadSkins()
    {
        PlayerSkins data = SaveSystem.LoadSkins();

        currentskinindex = data.currentskinindex;

        squidskins[0] = true;
        for(int i=1; i<=11; i++)
        {
            squidskins[i] = data.SquidSkins[i];
        }
    }

    public void SelectSkin(int Index)
    {
        SelectText[currentskinindex].text = "Owned";
        currentskinindex = Index;
        SelectText[currentskinindex].text = "Selected";
        SaveSystem.SaveSkins(this);
    }

    public void SaveSkins()
    {
        SaveSystem.SaveSkins(this);
    }
}
