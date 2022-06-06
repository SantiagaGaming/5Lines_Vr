using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class RadioButton : BaseButton
{
    [SerializeField] private Diet _diet;
    [SerializeField] private CanvasObject _canvasObject;
    private bool _radio = false;
    protected override void Start()
    {
        base.Start();
    }
    public override void OnClicked(InteractHand interactHand)
    {
     if(!_radio) _radio = true;
        else _radio = false;
        _diet.EnableDiet(_radio, _canvasObject.GetDietPosition());
    }
}
