using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class UIManager : MonoBehaviour
{
    public List<Button> InputStateActionButtons = new List<Button>();

    public void EnableAllButtons(bool enable)
    {
        foreach (var button in InputStateActionButtons)
        {
            button.interactable = enable;
        }
    }
}
