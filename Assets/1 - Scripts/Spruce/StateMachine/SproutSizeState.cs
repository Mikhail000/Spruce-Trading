using Spruce;
using UnityEngine;
using Scripts;

public class SproutSizeState : BaseState
{
    private new readonly SpruceBase _spruceBase;

    private readonly GameObject _smallSizeForm;
    
    private GameObject _bigSizeForm;

    private readonly ParticleSystem _growthEffect;

    public SproutSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        _smallSizeForm = spruceSpeciesData.smallSizeForm;
        _growthEffect = spruceSpeciesData.growthEffect;
    }
    
    public override void Enter()
    {
        base.Enter();
        _spruceBase.SpawnSprucePrefab(_smallSizeForm);
        Debug.Log("Я родился!");
    }

    public override void Exit()
    {
        base.Exit();
        _spruceBase.DestroySprucePrefab();
        _growthEffect.Play();
        Debug.Log("Вышли из состояния ростка");
    }

    public override void Update()
    {
        base.Update();
    }
}
