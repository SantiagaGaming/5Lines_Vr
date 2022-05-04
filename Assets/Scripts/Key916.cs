using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class Key916 : BaseObject
{
    override public void OnClicked(InteractHand interactHand)
    {
        gameObject.SetActive(false);
    }

}
