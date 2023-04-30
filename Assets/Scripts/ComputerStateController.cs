
    using System;
    using UnityEngine;

    public class ComputerStateController : StateController
    {
        public static ComputerStateController Instance;
        public GameEvent OnIdleStateEnterGE;
        public GameEvent OnComputerPlayedGE;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            
            OnComputerPlayed = OnComputerPlayedGE;
            OnIdleStateEnter = OnIdleStateEnterGE;
           SetComputerIdleStateWithADelay(0.2f);
        }

        public void SetPlayerStateActionAndSetComputerToPlay(IStateAction playerNewStateAction)
        {
            PlayerStateAction = playerNewStateAction;
            SetComputerPlayState();
           
        }

        public void SetComputerPlayState()
        {
            if (CurrentState.ToString() != nameof(TimeUpState))
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
            base.SetState(new IdleState());
        }
        

    }
