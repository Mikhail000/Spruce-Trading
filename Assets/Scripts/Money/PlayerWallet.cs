using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
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
    }

    public void WithdrawMoney(float amount)
    {
        Sum -= amount;
    }
}
