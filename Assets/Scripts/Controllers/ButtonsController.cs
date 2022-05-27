using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    [HideInInspector]public List<BaseButtton> Buttons = new List<BaseButtton>();
    [HideInInspector]public List<BackButtonObject> BackButtons = new List<BackButtonObject>();
    private void Awake()
    {
        foreach (var button in BackButtons)
        {
            button.BackButtonClickEvent += OnDisableButtons;
        }
    }
    public void OnDisableButtons()
    {
        foreach (var item in Buttons)
        {
            item.DisableButton();
            Debug.Log("Disabled");
        }
    }
}
