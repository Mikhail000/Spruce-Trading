using Spruce;

public abstract class SpruceState
{
    protected SpruceBase _spruceBase;
    public SpruceBase SpruceBase {set => _spruceBase = value; }
    public abstract void GoToNextState();
    public abstract void StopTransition();
}
