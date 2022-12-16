using Spruce;
using UnityEngine;

public class MediumSizeState : BaseState
{
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
        Debug.Log("Зашли в 'Среднее' состояние");
    }

    public override void Exit()
    {
        base.Exit();
        _spruceBase.DestroyPreviousSprucePrefab();
        Debug.Log("Вышли из 'Среднего' состояния");
    }

    public override void Update()
    {
        base.Update();
    }
}
