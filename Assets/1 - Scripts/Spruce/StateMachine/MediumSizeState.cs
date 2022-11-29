using Spruce;
using UnityEngine;

public class MediumSizeState : BaseState
{
    private new readonly SpruceBase _spruceBase;
    private readonly GameObject _mediumSizeForm;
    private readonly ParticleSystem _growthPartsEffect;
    

    public MediumSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        _mediumSizeForm = spruceSpeciesData.mediumSizeForm;
        _growthPartsEffect = spruceSpeciesData.growthEffect;
    }
    
    public override void Enter()
    {
        base.Enter();
        _spruceBase.SpawnSprucePrefab(_mediumSizeForm);
        _spruceBase.PlayGrowthPartsFX(_growthPartsEffect);
        Debug.Log("Вошли в состояние куста");
    }

    public override void Exit()
    {
        base.Exit();
        _spruceBase.DestroySprucePrefab();
        Debug.Log("Вышли из состояния куста");
    }

    public override void Update()
    {
        base.Update();
    }
}
