using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWithButton : BaseObject
{
    [SerializeField] private GameObject _button;
    [SerializeField] private GameObject _watchButton;
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
        if (_button != null)
            _button.SetActive(true);
        if (_watchButton != null)
            _watchButton.SetActive(true);
    }
    private void OnHideButton()
    {
        if (_button != null)
        _button.SetActive(false);
        if (_watchButton != null)
        _watchButton.SetActive(false);
    }

}
