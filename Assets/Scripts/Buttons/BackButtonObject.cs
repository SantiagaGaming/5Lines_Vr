using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class BackButtonObject : BaseButtton
{
    public UnityAction BackButtonClickEvent;
    private ButtonsController _buttonsController;
    private void Awake()
    {
        _buttonsController = FindObjectOfType<ButtonsController>();
        _buttonsController.BackButtons.Add(this);
        Debug.Log(_buttonsController.BackButtons.Count);
    }
    public override void OnClicked(InteractHand interactHand)
    {
        BackButtonClickEvent?.Invoke();
        CanvasController canvas = FindObjectOfType<CanvasController>();
        canvas.SetMeasureText(" ");
    }
}
