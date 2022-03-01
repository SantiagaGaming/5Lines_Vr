using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class InGameButton : MonoBehaviour,IClickAble
{
    [SerializeField] private GameObject[] _interactButtons;

    public void OnClicked(InteractHand interactHand)
    {
        foreach (var item in _interactButtons)
        {
            item.SetActive(true);
        }
    }
    public bool IsClickable { get; set; } = true;
}
