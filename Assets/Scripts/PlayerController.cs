using System;
using System.Collections.Generic;
using UnityEngine;

    public class PlayerController: MonoBehaviour
    {
        public int PlayerScore;
        public IStateAction CurrentStateAction;
        public GameEvent OnPlayerPlayedATurn;
        
        
        public void PlayerPlayedTurn(string stateActionName)
        {
            CurrentStateAction = GameDatabase.NameToStateActionMaps[stateActionName];
            OnPlayerPlayedATurn.Raise();
            ComputerStateController.Instance.SetPlayerStateActionAndSetComputerToPlay(CurrentStateAction);
        }
    }
