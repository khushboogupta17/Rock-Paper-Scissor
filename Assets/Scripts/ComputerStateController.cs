
    using System;
    using UnityEngine;

    public class ComputerStateController : StateController
    {
        public static ComputerStateController Instance;
        public GameEvent OnIdleStateEnter;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }

            Context = new Context();
           SetComputerIdleStateWithADelay(0.2f);
        }

        public void SetPlayerStateActionAndSetComputerToPlay(IStateAction playerNewStateAction)
        {
            Context.PlayerStateAction = playerNewStateAction;
            SetComputerPlayState();
           
        }

        public void SetComputerPlayState()
        {
            if (Context.CurrentState.ToString() != nameof(TimeUpState))
            {
                base.SetState(new PlayState());
            }
        }

        public void SetComputerIdleStateWithADelay(float delay = 0f)
        {
            Invoke(nameof(SetIdleState),delay);
           
        }

        public void SetComputerForTimeIsUpState()
        {
            base.SetState(new TimeUpState());
          
        }

        private void SetIdleState()
        {
            OnIdleStateEnter.Raise();
            base.SetState(new IdleState());
        }
        

    }
