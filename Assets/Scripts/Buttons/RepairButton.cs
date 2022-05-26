using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class RepairButton : BaseButtton
{
    [SerializeField] private MovebleObject _object;
    private ButtonsController _buttonController;
    protected override void Start()
    {
        base.Start();
        _buttonController = FindObjectOfType<ButtonsController>();
        _buttonController.Buttons.Add(this);
    }
    public override void OnClicked(InteractHand interactHand)
    {
        _object.RepairObject();
    }
}

