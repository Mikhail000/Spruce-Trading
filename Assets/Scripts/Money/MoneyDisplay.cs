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

    private void OnEnable()
    {

    }

    private void OnDisable()
    {

    }

    private void UpdateMoneyTextUI(int playerBalance)
    {
        _moneyDisplay.text = playerBalance.ToString();
    }
}
