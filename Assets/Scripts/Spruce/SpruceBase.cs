using System.Collections;
using System.Collections.Generic;
using Clicker;
using UnityEngine;

namespace Spruce
{
    public abstract class SpruceBase : StateMachine.StateMachine
    {
        [SerializeField] protected List<GameObject> spruceCondition;

        protected float Profit;

        protected readonly Click ClickValue;
        protected float CurrentClickValue;

        protected float MaxGrowthPoints;
        protected float AverageGrowthPoints;

        private int num;

        protected enum State : int { Small = 1, Medium = 2, Large = 3 }
        //private State _currentState;

        private float _growthPoints;

        protected virtual float GrowthPoints
        {
            get
            {
                return _growthPoints;
            }

            set
            {
                _growthPoints = value;
            }
        }

        private void Start()
        {
            if (spruceCondition[0].activeSelf == false)
                spruceCondition[0].SetActive(true);

            CurrentClickValue = ClickValue.OneClickValue;

            StartCoroutine(CheckGrowthPoints());
        }

        protected SpruceBase(float maxGrowthPoints, float profit)
        {
            //_currentState = State.Small;
            Profit = profit;
            MaxGrowthPoints = maxGrowthPoints;
            AverageGrowthPoints = MaxGrowthPoints / 2;
        }

        //private void OnEnable() => ClickReceiver.Click += IncreaseGrowthPoints;
        //private void OnDisable() => ClickReceiver.Click -= IncreaseGrowthPoints;

        protected void IncreaseGrowthPoints()
        {
            _growthPoints += CurrentClickValue;
        }

        protected IEnumerator CheckGrowthPoints()
        {
            while (this.gameObject)
            {
                if (_growthPoints <= AverageGrowthPoints || _growthPoints <= MaxGrowthPoints)
                {

                }
                yield return null;
            }
        }
    }
}
