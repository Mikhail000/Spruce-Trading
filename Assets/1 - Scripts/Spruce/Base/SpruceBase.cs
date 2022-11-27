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
        private BaseState _baseState;
        private StateMachine _st;
        
        private string _species;
        private float _maxGrowthPoints;
        private float _revenue;
        private float _mediumSizePointsMark;
        private float _bigSizePointsMark;
        private ParticleSystem _growthEffect;
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
            _manager = GameObject.Find("GameManager");
            _st = new StateMachine();
            
            
            _species = spruceSpeciesData.species;
            _maxGrowthPoints = spruceSpeciesData.maxGrowthPoints;
            _revenue = spruceSpeciesData.revenue;
            _mediumSizePointsMark = spruceSpeciesData.mediumSizePointsMark;
            _bigSizePointsMark = spruceSpeciesData.bigSizePointsMark;
            _growthEffect = spruceSpeciesData.growthEffect;
        }
        
        private void IncreaseGrowthPoints()
        {
            GrowthPoints += _manager.GetComponent<ClickData>().OneClickValue;
            if (GrowthPoints <= _mediumSizePointsMark)
            {
                
            }
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
        
    }
}
