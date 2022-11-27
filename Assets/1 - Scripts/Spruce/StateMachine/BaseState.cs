using Spruce;
using UnityEngine;

public abstract class BaseState
{
    protected SpruceBase _spruceBase;

    protected BaseState(SpruceBase spruceBase)
    {
        
    }

    public virtual void Enter(){}

    public virtual void Exit(){}

    public virtual void Update(){}

}
