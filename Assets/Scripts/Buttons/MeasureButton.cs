using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class MeasureButton : MonoBehaviour, IClickAble
{
    public UnityAction<Transform, string> MeasureButtonClickEvent;
    public virtual void OnClicked(InteractHand interactHand)
    {
        MeasureButtonClickEvent?.Invoke(transform,gameObject.name);
    }

    public bool IsClickable { get; set; } = true;
}