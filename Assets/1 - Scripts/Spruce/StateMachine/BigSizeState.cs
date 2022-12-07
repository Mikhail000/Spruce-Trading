using Spruce;
using UnityEngine;

public class BigSizeState : BaseState
{
    private new readonly SpruceBase _spruceBase;

    private readonly GameObject _bigSizeForm;
    private readonly ParticleSystem _growthEffect;
    private readonly ParticleSystem _growthPartsEffect;

    public BigSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        _bigSizeForm = spruceSpeciesData.bigSizeForm;
        _growthPartsEffect = spruceSpeciesData.growthEffect;
    }

    public override void Enter()
    {
        base.Enter();
        _spruceBase.SpawnSprucePrefab(_bigSizeForm);
        _spruceBase.PlayGrowthPartsFX(_growthPartsEffect);
        Debug.Log("Зашли в 'Большое' состояние");
    }

    public override void Exit()
    {
        base.Exit();
        _spruceBase.RemoveSpruceOnSell();
        Debug.Log("Вышли из 'Большого' состояния");
    }

    public override void Update()
    {
        base.Update();
    }
}
