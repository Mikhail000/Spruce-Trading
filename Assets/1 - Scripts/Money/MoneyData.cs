using UnityEngine;

public class MoneyData : MonoBehaviour
{
    private float _moneyBank;

    public float Money
    {
        get { return _moneyBank; }

        set
        {
            _moneyBank = value;
        }
    }
    
}
