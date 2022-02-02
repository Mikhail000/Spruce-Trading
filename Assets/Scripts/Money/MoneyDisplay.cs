using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(TMP_Text))]
public class MoneyDisplay : MonoBehaviour
{
    private MoneyManager _playerWallet;
    private TMP_Text _moneyDisplay;


    private void Start()
    {

    }

    private void OnEnable()
    {
        //MoneyManager.onChangeTextUI += UpdateMoneyTextUI;
    }

    private void OnDisable()
    {

    }

    private void UpdateMoneyTextUI(float money)
    {
        _moneyDisplay.text = money.ToString();
    }
}
