using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Player;
using AosSdk.Core.Interaction.Interfaces;
using UnityEngine.Events;

public class TeleportController : MonoBehaviour
{
    public UnityAction<string> TeleportEvent;
    [SerializeField] private Door[] _doors;
    [SerializeField] private CameraFlash _cameraFlash;
    [HideInInspector]public bool CanTeleport = true;

    private void Awake()
    {
        foreach (var Door in _doors)
        {
            Door.TeleportToObjectEvent += OnStartTeleporting;
        }
    }
    private void OnStartTeleporting(Transform newPlayerPosition, string name)
    {
        if(CanTeleport)
        {
            Player.Instance.TeleportTo(newPlayerPosition);
            _cameraFlash.CameraFlashStart();
            TeleportEvent?.Invoke(name);
        }
     
    }
}
