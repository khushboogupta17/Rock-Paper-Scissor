using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateAction
{
    public void Execute(Context context);
}
