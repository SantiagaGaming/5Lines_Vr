using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithButton : BaseObject
{
    [SerializeField] private GameObject[] _buttons;

    private ButtonsController _buttonsController;


    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        _buttonsController = FindObjectOfType<ButtonsController>();
        _buttonsController.OnDisableButtons();
        if (_buttons !=null)
        {
            foreach (var button in _buttons)
            {
                button.SetActive(true);
            }
        }  
    }
    private void OnHideButton()
    {
        if (_buttons != null)
        {
            foreach (var button in _buttons)
            {
                button.SetActive(false);
            }
        }
    }

}
