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
        
        private float _mediumSizePointsMark;
        
        private float _bigSizePointsMark;
    
        private GameObject _growthEffect;
        
        #endregion
        
        private float _currentClickValue;
        private Transform _sprucePrefabSpawnPoint;
        public GameObject growthFX;
        public ParticleSystem GrowthFX;

        public float CurrentGrowthPoints { get; set; }

        private void OnEnable() => ClickExtension.click += IncreaseGrowthPoints;
        private void OnDisable() => ClickExtension.click -= IncreaseGrowthPoints;

        private void Start()
        {
            //growthFX = _growthEffect;
            _sprucePrefabSpawnPoint = gameObject.GetComponent<Transform>();
            
            _manager = GameObject.Find("GameManager");
            _stateMachine = new StateMachine();
            _stateMachine.Initialize(new SproutSizeState(this));

            _species = spruceSpeciesData.species;
            _maxGrowthPoints = spruceSpeciesData.maxGrowthPoints;
            _revenue = spruceSpeciesData.revenue;

            _mediumSizePointsMark = spruceSpeciesData.mediumSizePointsMark;
            _bigSizePointsMark = spruceSpeciesData.bigSizePointsMark;
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

        public void PlayGrowthPartsFX(ParticleSystem growthEffect)
        {
            Instantiate(GrowthFX, _sprucePrefabSpawnPoint);
            GrowthFX.Play();
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
