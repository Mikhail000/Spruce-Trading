using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public BaseState CurrentState { get; set; }

    public void Initialize(BaseState startState)
    {
        CurrentState = startState;
        CurrentState.Enter();
    }

    public void ChangeState(BaseState newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();
    }
}
