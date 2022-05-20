using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithButton : BaseObject
{
    [SerializeField] private GameObject _button;
    [SerializeField] private BackButtonObject _backButton;

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
        CanvasController canvasController = FindObjectOfType<CanvasController>();
        canvasController.DisableActionButtons();
        _button.SetActive(true);
    }
    private void OnHideButton()
    {
        _button.SetActive(false);
    }

}
