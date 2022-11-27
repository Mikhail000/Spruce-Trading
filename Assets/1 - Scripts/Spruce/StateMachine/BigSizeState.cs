using Spruce;
using UnityEngine;

public class BigSizeState : BaseState
{
    private SpruceBase _spruceBase;

    private GameObject _bigSizeForm;
    private readonly ParticleSystem _growthEffect;

    public BigSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        _bigSizeForm = spruceSpeciesData.bigSizeForm;
        _growthEffect = spruceSpeciesData.growthEffect;
    }

    public override void Enter()
    {
        base.Enter();
        _spruceBase.SpawnSprucePrefab(_bigSizeForm);
        Debug.Log("Вошли в состояние большого дерева");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Пока Пошел нахуй");
    }

    public override void Update()
    {
        base.Update();
    }
}
