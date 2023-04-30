
    using UnityEngine;

    public class ScissorsStateAction : IStateAction
    {
        public string Name => "Scissors";

        public void Execute(Context context)
        {
            Debug.Log("Opponent is scissors");
            switch (context.PlayerStateAction.ToString())
            {
                case nameof(RockStateAction): Debug.Log("Player earned one point");
                    context.PlayerRoundResult = Context.RoundResult.Won;
                    break;
                
                case nameof(PaperStateAction): Debug.Log("Player lost one point");
                    context.PlayerRoundResult = Context.RoundResult.Lost;
                    break;
                
                case nameof(ScissorsStateAction): Debug.Log("It's a draw");
                    context.PlayerRoundResult = Context.RoundResult.Draw;
                    break;
                
                default: Debug.Log("Out of scope option");
                    break;
            }

        }
    }
