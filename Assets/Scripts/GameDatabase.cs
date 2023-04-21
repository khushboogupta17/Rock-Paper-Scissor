using System;
using System.Collections.Generic;
using DefaultNamespace;


    public static class GameDatabase
    {
        public static readonly Dictionary<string,IStateAction> NameToStateActionMaps =
            new Dictionary<string,IStateAction>()
            {
                {"Rock",new RockStateAction()},
                {"Paper",new PaperStateAction()},
                {"Scissors",new ScissorsStateAction()},
                
            };
        
       
    }

