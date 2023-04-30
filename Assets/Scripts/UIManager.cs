using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Button = UnityEngine.UI.Button;

public class UIManager : MonoBehaviour
{
    public List<Button> InputStateActionButtons = new List<Button>();
    public Transform PlayerHolder;
    public Transform ComputerHolder;
    public GameObject StateActionPrefab;
    public TextMeshProUGUI ResultText;
    
    public void EnableAllButtons(bool enable)
    {
        foreach (var button in InputStateActionButtons)
        {
            button.interactable = enable;
        }
    }

    public void DeleteAllPlayedActions()
    {
        foreach (Transform child in PlayerHolder.transform)
        {
            Destroy(child.gameObject);
        }
        
        foreach (Transform child in ComputerHolder.transform)
        {
            Destroy(child.gameObject);
        }
    }
    public void OnComputerPlayed()
    {
        SpawnStateAction(ComputerStateController.Instance.PlayerStateAction.Name,PlayerHolder);
        SpawnStateAction(ComputerStateController.Instance.ComputerStateAction.Name,ComputerHolder);
        switch (ComputerStateController.Instance.PlayerRoundResult)
        {
            case Context.RoundResult.Won: SetResultsText(true,"You Won");
                break;
            
            case Context.RoundResult.Lost: SetResultsText(true,"You Lost");
                break;
            
            case Context.RoundResult.Draw: SetResultsText(true,"It's a draw");
                break;
        }
        Debug.Log("Result:" + ComputerStateController.Instance.PlayerRoundResult);
    }

    void SpawnStateAction(string stateActionName, Transform parent)
    {
        var stateAction = Instantiate(StateActionPrefab, parent.position, parent.rotation, parent);
        stateAction.GetComponentInChildren<TextMeshProUGUI>().text = stateActionName;
    }

    private void SetResultsText(bool enable, string text = null)
    {
        EnableResultsText(enable);
        if (enable)
        {
            ResultText.text = text;
        }
    }

    public void EnableResultsText(bool enable)
    {
        ResultText.gameObject.SetActive(enable);
    }
    
}
