using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour, IClickAble, IHoverAble
{
    public UnityAction<Transform> TeleportToObjectEvent;
    public UnityAction AosTeleportEvent;
    public bool IsHoverable { get; set; } = true;

    public bool IsClickable { get; set; } = true;

    [SerializeField] private Transform _newPlayerPosition;
    public void StartTeleporting()
    {
        TeleportToObjectEvent?.Invoke(_newPlayerPosition);
        AosTeleportEvent?.Invoke();
    }
    public void OnClicked(InteractHand interactHand)
    {
        StartTeleporting();
    }

    public virtual void OnHoverIn(InteractHand interactHand)
    {
        if (GetComponent<Renderer>())
            GetComponent<Renderer>().material.color *= 1.5f;
        else if (GetComponentInChildren<Renderer>())
            GetComponentInChildren<Renderer>().material.color *= 1.5f;
        else if (GetComponentInParent<Renderer>())
            GetComponentInParent<Renderer>().material.color *= 1.5f;
        else return;

    }
    public virtual void OnHoverOut(InteractHand interactHand)
    {
        if (GetComponent<Renderer>())
            GetComponent<Renderer>().material.color /= 1.5f;
        else if (GetComponentInChildren<Renderer>())
            GetComponentInChildren<Renderer>().material.color /= 1.5f;
        else if (GetComponentInParent<Renderer>())
            GetComponentInParent<Renderer>().material.color /= 1.5f;
        else return;
    }
}
