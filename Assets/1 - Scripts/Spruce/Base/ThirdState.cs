using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdState : SpruceState
{
    public override void GoToNextState()
    {
    }

    public override void StopTransition()
    {
        _spruceBase.SetState(new ThirdState());
    }
}
