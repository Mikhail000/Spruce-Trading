using UnityEngine;

public class SecondState : SpruceState
{
    public SecondState()
    {
        
    }
    public override void GoToNextState()
    {
        _spruceBase.SetState(new ThirdState());
    }

    public override void StopTransition()
    {
    }
}
