using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    public void EnterState(IContext context);

    public void ExitState(IContext context);
}
