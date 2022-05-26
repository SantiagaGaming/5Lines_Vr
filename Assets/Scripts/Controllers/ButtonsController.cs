using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    [HideInInspector]public List<BaseButtton> Buttons = new List<BaseButtton>();
    public void DisableButtons()
    {
        foreach (var item in Buttons)
        {
            item.DisableButton();
        }
    }
}
