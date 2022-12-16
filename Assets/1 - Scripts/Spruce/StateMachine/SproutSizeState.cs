using Spruce;
using UnityEngine;

public class SproutSizeState : BaseState
{
    private readonly GameObject _smallSizeForm;
    private readonly ParticleSystem _growthPartsEffect;
    
    public SproutSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        _smallSizeForm = spruceSpeciesData.smallSizeForm;
        _growthPartsEffect = spruceSpeciesData.growthEffect;
    }
    
    public override void Enter()
    {
        base.Enter();
        _spruceBase.SpawnSprucePrefab(_smallSizeForm);
        _spruceBase.PlayGrowthPartsFX(_growthPartsEffect);
        Debug.Log("Зашли в 'Маленькое' состояние");
    }

    public override void Exit()
    {
        base.Exit();
        _spruceBase.DestroyPreviousSprucePrefab();
        Debug.Log("Вышли из 'Маленького' состояния");
    }

    public override void Update()
    {
        base.Update();
    }
}
