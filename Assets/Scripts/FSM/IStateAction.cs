using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateAction
{
    public string Name { get; }
    public void Execute(Context context);
}
