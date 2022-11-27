using System.Collections;
using System.Collections.Generic;
using Scripts;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

namespace Spruce
{
    public class SpruceBase : MonoBehaviour
    {
        public GameObject currentSprucePrefab;
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
        private Transform _sprucePrefabSpawnPoint;

        public float CurrentGrowthPoints { get; set; }

        private void OnEnable() => ClickExtension.click += IncreaseGrowthPoints;
        private void OnDisable() => ClickExtension.click -= IncreaseGrowthPoints;

        private void Start()
        {
            _sprucePrefabSpawnPoint = gameObject.GetComponent<Transform>();
            
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

        public void SpawnSprucePrefab(GameObject sprucePrefab)
        {
            
            currentSprucePrefab = sprucePrefab;
            currentSprucePrefab = Instantiate(currentSprucePrefab,_sprucePrefabSpawnPoint);
            Debug.Log("У тебя в руках игра - это мой хуй");
        }

        public void DestroySprucePrefab()
        {
            Destroy(currentSprucePrefab);
        }
        
        private void IncreaseGrowthPoints()
        {
            CurrentGrowthPoints += _manager.GetComponent<ClickData>().OneClickValue;

            if (CurrentGrowthPoints >= _mediumSizePointsMark)
            {
                _stateMachine.ChangeState(new MediumSizeState(this));
            }
            if (CurrentGrowthPoints >= _bigSizePointsMark)
            {
                _stateMachine.ChangeState(new BigSizeState(this));
            }
            
            Debug.Log("Елка растет!/n Очков роста -" + CurrentGrowthPoints);
        }

    }
}
