using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class StrelkaButton : BaseButtton
{
    [SerializeField] private bool _plus;
    [SerializeField] private StrelkaAOS _strelkaAOS;

    public override void OnClicked(InteractHand interactHand)
    {
        _strelkaAOS.TrySwitchStrelka(_plus);
    }
}
