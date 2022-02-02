//class -MoneyManager- contains states and behaviors for managing all money

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public delegate void MoneyChangeTextUI();

    public event MoneyChangeTextUI onChangeTextUI;

    private float _sum;

    public float Sum
    {
        get
        {
            return _sum;
        }
        private set
        {
            _sum = value;
        }
    }

    public void ChangeMoneyQuantity(float amount)
    {
        Sum += amount;
        onChangeTextUI?.Invoke();
    }

    public void WithdrawMoney(float amount)
    {
        Sum -= amount;
    }
}
