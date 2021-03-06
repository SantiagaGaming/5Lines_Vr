using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class BackButtonObject : BaseButton
{
    public UnityAction BackButtonClickEvent;

    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        ButtonsContainer.Instance.HideButtons();
        BackButtonClickEvent?.Invoke();
        CanvasController canvas = FindObjectOfType<CanvasController>();
        canvas.SetMeasureText(" ");
    }
}
