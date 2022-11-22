using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace Scripts
{
    [RequireComponent(typeof(TMP_Text))]

    public class MoneyDisplay : MonoBehaviour
    {
        private static TMP_Text _moneyDisplay;


        private void Start()
        {
            _moneyDisplay = gameObject.GetComponent<TMP_Text>();
        }


        public static void UpdateMoneyTextUI(float money, bool sign)
        {
            _moneyDisplay.text = money.ToString();
        }
    }
}

