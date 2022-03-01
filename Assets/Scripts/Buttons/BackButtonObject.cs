using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class BackButtonObject : MonoBehaviour, IClickAble
{
    public UnityAction BackButtonClickEvent;
    public virtual void OnClicked(InteractHand interactHand)
    {
        BackButtonClickEvent?.Invoke();
    }

    public bool IsClickable { get; set; } = true;
}
