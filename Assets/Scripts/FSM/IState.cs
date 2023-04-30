using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void EnterState(Context context);

    public void ExitState(Context context);
}
