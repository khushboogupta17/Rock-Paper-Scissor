using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerController: MonoBehaviour
    {
        public int PlayerScore;
        public IStateAction CurrentStateAction;
        
        
        public void PlayerPlayedTurn(string stateActionName)
        {
            CurrentStateAction = GameDatabase.NameToStateActionMaps[stateActionName];
            (new ComputerStateController()).SetPlayerStateActionAndSetComputerToPlay(CurrentStateAction);
        }
    }
}