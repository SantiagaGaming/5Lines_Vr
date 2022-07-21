using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithButton : BaseObject
{
    [SerializeField] private GameObject[] _buttons;
    [SerializeField] private Transform _buttonsPos;
    [SerializeField] private bool _vertical;

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
        if (_buttonsPos == null && !_vertical)
            MovingButtonsController.Instance.SetMovingButtonsPosition(transform.position + new Vector3(0f, 0.12f, 0));
        else if(_buttonsPos == null && _vertical)
            MovingButtonsController.Instance.SetMovingButtonsPosition(transform.position + new Vector3(0.09f, 0.05f, 0));
        else
            MovingButtonsController.Instance.SetMovingButtonsPosition(_buttonsPos.position);
        MovingButtonsController.Instance.ObjectName = gameObject.name;
        MovingButtonsController.Instance.ShowAllButtons();

    }

}
