
    using UnityEngine;

    public class ScissorsStateAction : IStateAction
    {
        public void Execute(IContext context)
        {
            Debug.Log("Opponent is scissors");
            switch (context.PlayerStateAction.ToString())
            {
                case nameof(RockStateAction): Debug.Log("Player earned one point");
                    break;
                
                case nameof(PaperStateAction): Debug.Log("Player lost one point");
                    break;
                
                case nameof(ScissorsStateAction): Debug.Log("It's a draw");
                    break;
                
                default: Debug.Log("Out of scope option");
                    break;
            }
            
            (new ComputerStateController()).SetState(new WaitState());
        }
    }
