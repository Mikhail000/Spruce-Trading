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

        private GameObject manager;
        private string _species;
        private float _maxGrowthPoints;
        private float _revenue;

        private float _growthPoints;
        private float _currentClickValue;

        public float GrowthPoints
        {
            get { return _growthPoints; }
            set { _growthPoints = value; }
        }
        
        private void OnEnable() => ClickExtension.click += IncreaseGrowthPoints;
        private void OnDisable() => ClickExtension.click -= IncreaseGrowthPoints;

        private void Start()
        {
            _species = spruceSpeciesData.species;
            _maxGrowthPoints = spruceSpeciesData.maxGrowthPoints;
            _revenue = spruceSpeciesData.revenue;
            manager = GameObject.Find("GameManager");
        }
        
        protected void IncreaseGrowthPoints()
        {
            GrowthPoints += manager.GetComponent<ClickData>().OneClickValue;
            Debug.Log("Елка растет!/n Очков роста -" + GrowthPoints);
        }

        protected IEnumerator CheckGrowthPoints()
        {
            while (gameObject)
            {
                if (_growthPoints <= 1 || _growthPoints <= 2)
                {

                }
                yield return null;
            }
        }
    }
}
