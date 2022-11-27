using Spruce;
using UnityEngine;

public class BigSizeState : BaseState
{
    private SpruceBase _spruceBase;

    private readonly ParticleSystem _growthEffect;

    public BigSizeState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
        
        var spruceSpeciesData = _spruceBase.spruceSpeciesData;
        
        _growthEffect = spruceSpeciesData.growthEffect;
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Вошли в состояние большого дерева");
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
    }
}
