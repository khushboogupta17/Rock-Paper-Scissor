
public abstract class StateController :  IContext
{
    public override void SetState(IState newState)
    {
        m_currentState?.ExitState(this);
        m_currentState = newState;
        m_currentState.EnterState(this);
    }
}

public abstract class IContext
{
    public IStateAction PlayerStateAction;
    public virtual void SetState(IState newState){}
    protected IState m_currentState;
}
