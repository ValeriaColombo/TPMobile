using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    private int amount = 0;
    [SerializeField] private TMP_Text text;
    [SerializeField] private string currency;
    [SerializeField] private int amountByClick = 1;

    private void Start()
    {
        UpdateText();
    }

    public void OnBtnBuyClick()
    {
        amount += amountByClick;
        UpdateText();
        Debug.Log(currency + " purchase x" + amountByClick + " succesfull. New amount: " + amount.ToString());
    }

    private void UpdateText()
    {
        text.text = amount.ToString();
    }
}
