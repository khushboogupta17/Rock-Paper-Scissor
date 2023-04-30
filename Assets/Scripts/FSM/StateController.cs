
using UnityEngine;

public class StateController : MonoBehaviour
{
    public Context Context;

    public void SetState(IState newState)
    {
        Context.CurrentState?.ExitState(Context);
        Context.CurrentState = newState;
        Context.CurrentState.EnterState(Context);
    }
}

public class Context
{
    public IStateAction PlayerStateAction;
    public IState CurrentState;
    public Timer Timer;
}
