
using UnityEngine;

public class StateController : MonoBehaviour, Context
{
    public IStateAction PlayerStateAction { get; set; }
    public IState CurrentState { get; set; }
    public IStateAction ComputerStateAction { get; set; }
    public GameEvent OnComputerPlayed { get; set; }
    public GameEvent OnIdleStateEnter { get; set; }
    public Context.RoundResult PlayerRoundResult { get; set; }
    
    public void SetState(IState newState)
    {
        CurrentState?.ExitState(this);
        CurrentState = newState;
        CurrentState.EnterState(this);
    }

   
}

public interface Context
{
    public IStateAction PlayerStateAction { get; set; }
    public IState CurrentState { get; set; }
    public IStateAction ComputerStateAction { get; set; }
    public GameEvent OnComputerPlayed { get; set; }
    public GameEvent OnIdleStateEnter { get; set; }
    public RoundResult PlayerRoundResult { get; set; }

    public enum RoundResult
    {
        Won, Lost, Draw, Default
    }
}
