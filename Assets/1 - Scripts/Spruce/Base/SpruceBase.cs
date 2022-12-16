using Scripts;
using UnityEngine;

namespace Spruce
{
    public class SpruceBase : MonoBehaviour
    {
        /*--Состояния--*/
        
        #region Data, Nodes

        public GameObject currentSprucePrefab;
        public SpruceSpeciesData spruceSpeciesData;

        private ParticleSystem _growthFX;
        private GameObject _manager;
        private BaseState _baseState;
        private StateMachine _stateMachine;
        

        #endregion
        
        #region Common Parameters
        public float CurrentGrowthPoints { get; set; }
        
        private string _species;
        private float _maxGrowthPoints;
        private float _revenue;
        private float _currentClickValue;
        private Transform _sprucePrefabSpawnPoint;
        
        #endregion
        
        #region Tree's Prefabs & Size Mark Points
        
        private float _mediumSizePointsMark;
        
        private float _bigSizePointsMark;
    
        private GameObject _growthEffect;

        private bool _isSwitchable;

        private bool _isReadyToHarvest;
        
        #endregion
        
        /*--Поведения--*/

        private void OnEnable() => ClickExtension.click += IncreaseGrowthPoints;
        private void OnDisable() => ClickExtension.click -= IncreaseGrowthPoints;

        private void Start()
        {
            _isSwitchable = false;
            _isReadyToHarvest = false;
            
            _sprucePrefabSpawnPoint = gameObject.GetComponent<Transform>();
            
            _manager = GameObject.Find("GameLogicHub");
            _stateMachine = gameObject.AddComponent<StateMachine>();
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
        }

        public void DestroyPreviousSprucePrefab()
        {
            Destroy(currentSprucePrefab);
        }

        public void RemoveSpruceOnSell()
        {
            Destroy(gameObject);
        }

        public void PlayGrowthPartsFX(ParticleSystem growthEffect)
        {
            _growthFX = Instantiate(growthEffect, _sprucePrefabSpawnPoint);
            _growthFX.Play();
        }

        public void SetToHarvest()
        {
            _stateMachine.StopStateMachine(_stateMachine);
        }
        
        private void IncreaseGrowthPoints()
        {
            if (CurrentGrowthPoints < _maxGrowthPoints)
            {
                CurrentGrowthPoints += _manager.GetComponent<ClickData>().OneClickValue;
                Debug.Log("Growth points - " + CurrentGrowthPoints);
                
                if (CurrentGrowthPoints >= _mediumSizePointsMark && !_isSwitchable)
                {
                    _stateMachine.ChangeState(new MediumSizeState(this));
                    _isSwitchable = true;
                }
                else if(CurrentGrowthPoints >= _bigSizePointsMark)
                {
                    _isSwitchable = false;
                    if (!_isSwitchable)
                    {
                        _stateMachine.ChangeState(new BigSizeState(this));  
                    }
                    _isSwitchable = true;
                }
                
            }
            else if (CurrentGrowthPoints >= _maxGrowthPoints && !_isReadyToHarvest)
            {
                _stateMachine.ChangeState(new HarvestedSpruceState(this));
                _isReadyToHarvest = true;
            }

            
        }
    }
}
