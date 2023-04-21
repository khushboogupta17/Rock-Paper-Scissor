
    using UnityEngine;

    public class ComputerStateController : StateController
    {
        public void SetPlayerStateActionAndSetComputerToPlay(IStateAction playerNewStateAction)
        {
            PlayerStateAction = playerNewStateAction;
            base.SetState(new PlayState());
        }
       
    }
