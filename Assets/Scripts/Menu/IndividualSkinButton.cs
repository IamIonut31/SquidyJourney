using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IndividualSkinButton : MonoBehaviour
{
    public int skinindex;
    public int skinprice;
    [SerializeField] GameObject skinpreview;
    [SerializeField] TextMeshProUGUI pricepreview;

    public void ShowDetails()
    {
        skinpreview.GetComponent<Image>().sprite = this.gameObject.GetComponent<Image>().sprite;
        pricepreview.text = skinprice.ToString();
        BuySkinButton.ActualSkinPrice = skinprice;
        BuySkinButton.ActualSkinIndex = skinindex;
    }
}
