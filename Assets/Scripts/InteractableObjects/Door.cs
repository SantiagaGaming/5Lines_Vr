using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class Door : BaseObject
{
    public UnityAction<Transform, string> TeleportToObjectEvent;
    public UnityAction AosTeleportEvent;
    [SerializeField] private Transform _newPlayerPosition;
    [SerializeField] private string _locationName;

    public void StartTeleporting()
    {
        TeleportToObjectEvent?.Invoke(_newPlayerPosition, gameObject.name);
        AosTeleportEvent?.Invoke();
    }
   override public void OnClicked(InteractHand interactHand)
    {
        StartTeleporting();
        LocationController locationController = FindObjectOfType<LocationController>();
        locationController.SetLocationText(_locationName);
    }




}
