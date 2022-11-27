using System.Collections;
using System.Collections.Generic;
using Scripts;
using UnityEngine;
using UnityEngine.Serialization;

namespace Spruce
{
    public class SpruceBase : MonoBehaviour
    {
        public Transform currentSprucePrefab;
        public SpruceSpeciesData spruceSpeciesData;
        
        private GameObject _manager;
        private BaseState _baseState;
        private StateMachine _stateMachine;
        
        #region Common Parameters

        private string _species;
        private float _maxGrowthPoints;
        private float _revenue;

        #endregion
        
        
        #region Tree's Prefabs & Size Mark Points

        private GameObject _smallSizeForm;
        private float _smallSizePointsMark;
        
        private GameObject _mediumSizeForm;
        private float _mediumSizePointsMark;
    
        private GameObject _bigSizeForm;
        private float _bigSizePointsMark;
    
        private ParticleSystem _growthEffect;
        
        #endregion
        
        private float _currentClickValue;

        public float CurrentGrowthPoints { get; set; }

        private void OnEnable() => ClickExtension.click += IncreaseGrowthPoints;
        private void OnDisable() => ClickExtension.click -= IncreaseGrowthPoints;

        private void Start()
        {
            _manager = GameObject.Find("GameManager");
            _stateMachine = new StateMachine();
            _stateMachine.Initialize(new SproutSizeState(this));
            
            _species = spruceSpeciesData.species;
            _maxGrowthPoints = spruceSpeciesData.maxGrowthPoints;
            _revenue = spruceSpeciesData.revenue;

            _smallSizeForm = spruceSpeciesData.smallSizeForm;
            _smallSizePointsMark = spruceSpeciesData.smallSizePointsMark;

            _mediumSizeForm = spruceSpeciesData.mediumSizeForm;
            _mediumSizePointsMark = spruceSpeciesData.mediumSizePointsMark;

            _bigSizeForm = spruceSpeciesData.bigSizeForm;
            _bigSizePointsMark = spruceSpeciesData.bigSizePointsMark;

            _growthEffect = spruceSpeciesData.growthEffect;
        }
        
        private void IncreaseGrowthPoints()
        {
            CurrentGrowthPoints += _manager.GetComponent<ClickData>().OneClickValue;

            if (CurrentGrowthPoints >= _mediumSizePointsMark)
            {
                
            }
            
            Debug.Log("Елка растет!/n Очков роста -" + CurrentGrowthPoints);
        }

    }
}
