using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class EnableImageButton : BaseButtton
{
    [SerializeField] private GameObject _object;

    public override void OnClicked(InteractHand interactHand)
    {
        if (_object.activeSelf)
        {
            _object.SetActive(false);
        }
        else _object.SetActive(true);
    }
}
