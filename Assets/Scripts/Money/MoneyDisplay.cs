using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyDisplay : MonoBehaviour
{
    private PlayerWallet _playerWallet;
    private TMP_Text _moneyDisplay;

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        
    }
    
    private void ChangeBalance(int playerBalance)
    {
        _moneyDisplay.text = playerBalance.ToString();
    }
}
