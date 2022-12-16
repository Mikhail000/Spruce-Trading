using System.Collections;
using System.Collections.Generic;
using Spruce;
using UnityEngine;

public class HarvestedSpruceState : BaseState
{
    private readonly ParticleSystem _growthPartsEffect;
    public HarvestedSpruceState(SpruceBase spruceBase) : base(spruceBase)
    {
        _spruceBase = spruceBase;
    }

    public override void Enter()
    {
        base.Enter();
        _spruceBase.SetToHarvest();
    }
    
}
