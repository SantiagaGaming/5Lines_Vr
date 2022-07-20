using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithButton : BaseObject
{
    [SerializeField] private GameObject[] _buttons;

    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        //ButtonsContainer.Instance.HideButtons();
        //if (_buttons !=null)
        //{
        //    foreach (var button in _buttons)
        //    {
        //        button.SetActive(true);
        //    }
        //}  
    
            MovingButtonsController.Instance.SetMovingButtonsPosition(transform.position + new Vector3(0f, 0.15f, 0));

    }

}
