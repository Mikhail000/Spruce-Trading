using Spruce;
using UnityEngine;

public class MediumSizeState : BaseState
{
    private SpruceBase _spruceBase;

    private GameObject _mediumSizeForm;
    private readonly ParticleSystem _growthEffect;

    public MediumSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        _mediumSizeForm = spruceSpeciesData.mediumSizeForm;
        _growthEffect = spruceSpeciesData.growthEffect;
    }
    
    public override void Enter()
    {
        base.Enter();
        _spruceBase.SpawnSprucePrefab(_mediumSizeForm);
        Debug.Log("Вошли в состояние куста");
    }

    public override void Exit()
    {
        base.Exit();
        _spruceBase.DestroySprucePrefab();
        _growthEffect.Play();
        Debug.Log("Вышли из состояния куста");
    }

    public override void Update()
    {
        base.Update();
    }
}
