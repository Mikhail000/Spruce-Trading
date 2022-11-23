using System.Collections;
using System.Collections.Generic;
using Scripts;
using UnityEngine;
using UnityEngine.Serialization;

namespace Spruce
{
    public class SpruceBase : MonoBehaviour
    {
        [SerializeField] private SpruceSpeciesData spruceSpeciesData;
        private GameObject _manager;
        private SpruceState _spruceState;
        
        private string _species;
        private float _maxGrowthPoints;
        private float _revenue;
        private ParticleSystem _growthEffect;
        private float _growthPoints;
        private float _currentClickValue;
        
        public float GrowthPoints
        {
            get { return _growthPoints; }
            set { _growthPoints = value; }
        }

        private SpruceBase(SpruceState spruceState)
        {
            SetState(spruceState);
        }
        
        private void OnEnable() => ClickExtension.click += IncreaseGrowthPoints;
        private void OnDisable() => ClickExtension.click -= IncreaseGrowthPoints;

        private void Start()
        {
            _species = spruceSpeciesData.species;
            _maxGrowthPoints = spruceSpeciesData.maxGrowthPoints;
            _revenue = spruceSpeciesData.revenue;
            _growthEffect = spruceSpeciesData.growthEffect;
            _manager = GameObject.Find("GameManager");
        }
        
        private void IncreaseGrowthPoints()
        {
            GrowthPoints += _manager.GetComponent<ClickData>().OneClickValue;
            Debug.Log("Елка растет!/n Очков роста -" + GrowthPoints);
        }

        private IEnumerator CheckGrowthPoints()
        {
            while (gameObject)
            {
                if (_growthPoints <= 1 || _growthPoints <= 2)
                {

                }
                yield return null;
            }
        }

        public void SetState(SpruceState spruceState)
        {
            _spruceState = spruceState;
            _spruceState.SpruceBase = this;
        }
        
    }
}
