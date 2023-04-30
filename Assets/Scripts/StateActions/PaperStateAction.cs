
    using UnityEngine;

    public class PaperStateAction : IStateAction
    {
        public string Name => "Paper"; 

        public void Execute(Context context)
        {
            Debug.Log("Opponent is paper");
            switch (context.PlayerStateAction.ToString())
            {
                case nameof(ScissorsStateAction): Debug.Log("Player earned one point");
                    context.PlayerRoundResult = Context.RoundResult.Won;
                    break;
                
                case nameof(RockStateAction): Debug.Log("Player lost one point");
                    context.PlayerRoundResult = Context.RoundResult.Lost;
                    break;
                
                case nameof(PaperStateAction): Debug.Log("It's a draw");
                    context.PlayerRoundResult = Context.RoundResult.Draw;
                    break;
                
                default: Debug.Log("Out of scope option");
                    break;
            }

           
        }
    }
