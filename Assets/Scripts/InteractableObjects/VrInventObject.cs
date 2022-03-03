using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class VrInventObject : MonoBehaviour, IClickAble
{
    [SerializeField] private GameObject _objectToShow;
    public virtual void OnClicked(InteractHand interactHand)
    {
if(_objectToShow.activeSelf == true)
        {
            _objectToShow.SetActive(false);
        }
else
        {
            _objectToShow.SetActive(true);
        }
    }
    public bool IsClickable { get; set; } = true;
}
