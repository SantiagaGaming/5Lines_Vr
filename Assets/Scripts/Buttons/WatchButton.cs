using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class WatchButton : BaseButton
{
    /// <summary>
    /// TODO состояние объекта.
    /// </summary>
    /// <param name="interactHand"></param>
    /// 
    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        print("Осмотрено");
    }

}
