
    using System;
    using DefaultNamespace;
    using UnityEngine;


    public class RockStateAction : IStateAction
    {
        
        public void Execute(IContext context)
        {
            Debug.Log("Opponent is rock");
            switch (context.PlayerStateAction.ToString())
            {
                case nameof(PaperStateAction): Debug.Log("Player earned one point");
                    break;
                
                case nameof(ScissorsStateAction): Debug.Log("Player lost one point");
                    break;
                
                case nameof(RockStateAction): Debug.Log("It's a draw");
                    break;
                
                default: Debug.Log("Out of scope option");
                    break;
            }
            
            (new ComputerStateController()).SetState(new WaitState());
        }
    }
