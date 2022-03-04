using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class MeasureButton : MonoBehaviour, IClickAble, IHoverAble
{
    public UnityAction<Transform, string> MeasureButtonClickEvent;
    public bool IsClickable { get; set; } = true;
    public bool IsHoverable { get; set; } = true;
    public virtual void OnClicked(InteractHand interactHand)
    {
        MeasureButtonClickEvent?.Invoke(transform,gameObject.name);
    }

    public void OnHoverIn(InteractHand interactHand)
    {
        transform.localScale *= 2;
    }
    public void OnHoverOut(InteractHand interactHand)
    {
        transform.localScale /= 2;
    }

}