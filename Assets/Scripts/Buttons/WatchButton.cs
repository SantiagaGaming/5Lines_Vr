using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class WatchButton : BaseButtton
{
    private ButtonsController _buttonController;
    /// <summary>
    /// TODO ��������� �������.
    /// </summary>
    /// <param name="interactHand"></param>
    /// 
    protected override void Start()
    {
        base.Start();
        _buttonController = FindObjectOfType<ButtonsController>();
        _buttonController.Buttons.Add(this);
    }
    public override void OnClicked(InteractHand interactHand)
    {
        print("���������");
    }

}
