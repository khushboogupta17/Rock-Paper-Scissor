
    using UnityEditor.Timeline.Actions;
    using UnityEngine;

    public class TimeUpState : IState
    {
        public void EnterState(Context context)
        {
            Debug.Log("Time up state, restarting game");
           ComputerStateController.Instance.SetComputerIdleStateWithADelay(0.5f);
          
        }

        public void ExitState(Context context)
        {
        }
        
    }
