using Spruce;
using UnityEngine;

public class SproutSizeState : BaseState
{
    private SpruceBase _spruceBase;

    private Transform _currentSprucePrefab;

    private readonly ParticleSystem _growthEffect;

    public SproutSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;

        _currentSprucePrefab = _spruceBase.currentSprucePrefab;
        
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        
        _growthEffect = spruceSpeciesData.growthEffect;
    }
    
    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
        _growthEffect.Play();
        Debug.Log("Вышли из состояния ростка");
    }

    public override void Update()
    {
        base.Update();
    }
}
