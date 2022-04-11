using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class AmperButton : BaseButtton
{
    [SerializeField] private Ampermetr _ampermetr;
    [SerializeField] private GameObject _measureButtons;
    [SerializeField] private CanvasObject _canvasObject;
    [SerializeField] private BackButtonObject _backButton;
    private bool _amper = false;
    private void OnEnable()
    {
        _backButton.BackButtonClickEvent += OnDisableMeasureButtons;
    }
    private void OnDisable()
    {
        _backButton.BackButtonClickEvent -= OnDisableMeasureButtons;
    }
    public override void OnClicked(InteractHand interactHand)
    {
        if(_canvasObject.GetMeasureValue())
        {
            if (!_amper)
            {
                _amper = true;
                _measureButtons.SetActive(true);
                _canvasObject.EnableObjectsColliders(false);
            }
            else
            {
                _amper = false;
                _measureButtons.SetActive(false);
                ShupController shup = FindObjectOfType<ShupController>();
                shup.ResetShupPosition();
                _canvasObject.EnableObjectsColliders(true);
            }
            _ampermetr.EnableAmper(_amper, _canvasObject.GetAmperPosition());
            _canvasObject.DisaleActionButtons();
        }

    }
    private void OnDisableMeasureButtons()
    {
        _measureButtons.SetActive(false);
        _amper = false;
    }
}

