using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithButton : BaseObject
{
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _2button;
    [SerializeField] private BackButtonObject _backButton;
    private ButtonsController _buttonsController;

    private void OnEnable()
    {
        _backButton.BackButtonClickEvent += OnHideButton;
    }
    private void OnDisable()
    {
        _backButton.BackButtonClickEvent -= OnHideButton;
    }
    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        _buttonsController = FindObjectOfType<ButtonsController>();
        _buttonsController.DisableButtons();
        if (_button != null)
            _button.SetActive(true);
        if (_2button != null)
            _2button.SetActive(true);
    }
    private void OnHideButton()
    {
        if (_button != null)
        _button.SetActive(false);
        if (_2button != null)
        _2button.SetActive(false);
    }

}
