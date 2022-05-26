using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class AdjustButton : BaseButtton
{
    /// <summary>
    /// TODO состояние объекта.
    /// </summary>
    /// <param name="interactHand"></param>
    public override void OnClicked(InteractHand interactHand)
    {
        print("Проверено");
    }

}

