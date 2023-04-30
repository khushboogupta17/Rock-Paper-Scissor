
    using UnityEngine;
    
    public class RockStateAction : IStateAction
    {
        public string Name => "Rock";

        public void Execute(Context context)
        {
            Debug.Log("Opponent is rock");
            switch (context.PlayerStateAction.ToString())
            {
                case nameof(PaperStateAction): Debug.Log("Player earned one point");
                    context.PlayerRoundResult = Context.RoundResult.Won;
                    break;
                
                case nameof(ScissorsStateAction): Debug.Log("Player lost one point");
                    context.PlayerRoundResult = Context.RoundResult.Lost;
                    break;
                
                case nameof(RockStateAction): Debug.Log("It's a draw");
                    context.PlayerRoundResult = Context.RoundResult.Draw;
                    break;
                
                default: Debug.Log("Out of scope option");
                    break;
            }
          
        }
    }
