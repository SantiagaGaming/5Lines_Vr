using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class RepairButton : MonoBehaviour, IClickAble
{
    [SerializeField] private MovebleObject _object;
    public virtual void OnClicked(InteractHand interactHand)
    {
        _object.RepairObject();
    }

    public bool IsClickable { get; set; } = true;
}

