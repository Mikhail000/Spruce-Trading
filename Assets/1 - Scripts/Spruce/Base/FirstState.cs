using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstState : SpruceState
{
    public override void GoToNextState()
    {
        _spruceBase.SetState(new SecondState());
    }

    public override void StopTransition()
    {
    }
}
