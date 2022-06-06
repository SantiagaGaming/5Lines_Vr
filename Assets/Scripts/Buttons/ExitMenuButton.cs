using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenuButton : BaseButtton
{
    [SerializeField] private EscButton _escButton;
    [SerializeField] private MenuButton _menuButton;
    [SerializeField] private MainMenuController _mainController;
    public override void OnClicked(InteractHand interactHand)
    {
        _escButton.ChangeShowValue(false);
        _menuButton.ChangeShowValue(false);
        _mainController.TeleportToPreviousLocation();

    }
}
