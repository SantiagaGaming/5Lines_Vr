using AosSdk.Core.Player.Pointer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingButton : BaseButton
{
    [SerializeField] private string _actionText;
    public override void OnHoverIn(InteractHand interactHand)
    {
        transform.localScale *= 1.5f;
        if (helperPos != null)
        {
            string temptext = $"{_actionText} {MovingButtonsController.Instance.ObjectName}";
            canvasHelper.ShowTextHelper(temptext, helperPos);

        }
            
    }
    public override void OnHoverOut(InteractHand interactHand)
    {
        transform.localScale /= 1.5f;
        if (helperPos != null)
            canvasHelper.HidetextHelper();
    }
}
