
    public class IdleState : IState
    {
        private Context _context;
        public GameEventListener GameEventListener;
        public void EnterState(Context context)
        {
            _context = context;
           // context.Timer.StartTimer();
            //context.Timer.OnTimeIsUp.Listeners.Add();
            //start timer
            //move to time is up state once timer ends
        }

        public void ExitState(Context context)
        {
            
        }

        public void OnTimeIsUp()
        {
            ExitState(_context);
        }
    }
