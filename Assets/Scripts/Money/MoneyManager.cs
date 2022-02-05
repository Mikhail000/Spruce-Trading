//class -MoneyManager- contains states and behaviors for managing all money

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    public class MoneyManager : MonoBehaviour
    {
        /*-FIELDS-*/

        private static float _sum;
        private static bool _sign;

        private MoneyDisplay _moneyDisplay;

        /*-DELEGATES-*/

        public delegate void MoneyChangeTextUI(float money, bool sign);

        MoneyChangeTextUI moneyDisplay = new MoneyChangeTextUI(MoneyDisplay.UpdateMoneyTextUI);
        //MoneyChangeTextUI moneyChange;

        /*-PROPERTIES-*/

        public static bool Sign
        {
            get
            {
                return _sign;
            }
            private set
            {
                _sign = value;
            }
        }

        public static float Sum
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
}

