using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class WatchButton : MonoBehaviour, IClickAble
{
   /// <summary>
   /// TODO состояние объекта.
   /// </summary>
   /// <param name="interactHand"></param>
    public virtual void OnClicked(InteractHand interactHand)
    {
        print("исправно");
    }

    public bool IsClickable { get; set; } = true;
}
