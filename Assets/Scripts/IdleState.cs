
    public class IdleState : IState
    {
  
        public void EnterState(Context context)
        {
            context.OnIdleStateEnter.Raise();
        }

        public void ExitState(Context context)
        {
        }
        
    }
