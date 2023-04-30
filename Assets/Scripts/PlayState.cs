using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using UnityEditor;
using Random = UnityEngine.Random;

public class PlayState : IState
{
        private List<IStateAction> m_stateActionsList;
        
        public void EnterState(Context context)
        {
            m_stateActionsList = GameDatabase.NameToStateActionMaps.Values.ToList();
            int randomInd = Random.Range(0, m_stateActionsList.Count);
            m_stateActionsList[randomInd].Execute(context);
        }

        public void ExitState(Context context)
        {
            
        }
}
