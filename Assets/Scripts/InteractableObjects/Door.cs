using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class Door : BaseObject
{
    public UnityAction<Transform> TeleportToObjectEvent;
    public UnityAction AosTeleportEvent;

    [SerializeField] private Transform _newPlayerPosition;
    public void StartTeleporting()
    {
        TeleportToObjectEvent?.Invoke(_newPlayerPosition);
        AosTeleportEvent?.Invoke();
    }
   override public void OnClicked(InteractHand interactHand)
    {
        StartTeleporting();
    }

}
