using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class VrInventButton : BaseButtton
{
    [SerializeField] private GameObject _objectToShow;
    public override void OnClicked(InteractHand interactHand)
    {

        if (_objectToShow.activeSelf == true)
        {
            _objectToShow.SetActive(false);
        }
        else
        {
            _objectToShow.SetActive(true);
        }
    
     }
}
