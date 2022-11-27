using Spruce;
using UnityEngine;

public class MediumSizeState : BaseState
{
    private SpruceBase _spruceBase;

    private readonly ParticleSystem _growthEffect;

    public MediumSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        
        _growthEffect = spruceSpeciesData.growthEffect;
    }
    
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Вошли в состояние куста");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Вышли из состояния куста");
    }

    public override void Update()
    {
        base.Update();
    }
}
