
    using UnityEngine;

    public class PaperStateAction : IStateAction
    {
        public void Execute(Context context)
        {
            Debug.Log("Opponent is paper");
            switch (context.PlayerStateAction.ToString())
            {
                case nameof(ScissorsStateAction): Debug.Log("Player earned one point");
                    break;
                
                case nameof(RockStateAction): Debug.Log("Player lost one point");
                    break;
                
                case nameof(PaperStateAction): Debug.Log("It's a draw");
                    break;
                
                default: Debug.Log("Out of scope option");
                    break;
            }

            ComputerStateController.Instance.SetComputerIdleStateWithADelay(1f);
        }
    }
