using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
using AosSdk.ThirdParty.QuickOutline.Scripts;

public class BaseObject : MonoBehaviour, IClickAble, IHoverAble
{

    public bool Button;
    public bool IsHoverable { get; set; } = true;
    public bool IsClickable { get; set; } = true;

    protected CanvasController canvasController;
    protected CanvasObjectHelperController canvasHelper;

    [SerializeField] protected OutlineCore[] outlineObjects;
    [SerializeField] protected Transform helperPos;
    [SerializeField] protected string helperName;

    protected virtual void Start()
    {
        canvasController = FindObjectOfType<CanvasController>();
        canvasHelper = FindObjectOfType<CanvasObjectHelperController>();
        if(Button)
        ButtonsContainer.Instance.AddButton(this);
    }

    public virtual void OnClicked(InteractHand interactHand)
    {

        AosObjectManager.Instance.InvokeOnClick(gameObject.name);

    }
    public virtual void OnHoverIn(InteractHand interactHand)
    {
        if (helperPos != null)
            canvasHelper.ShowTextHelper(helperName, helperPos);
        if (outlineObjects != null)
            foreach (var obj in outlineObjects)
            {
                obj.enabled = true;
                obj.OutlineWidth = 3;
            }
    }
    public virtual void OnHoverOut(InteractHand interactHand)
    {  if (helperPos != null)
        canvasHelper.HidetextHelper();
        if (outlineObjects != null)
            foreach (var obj in outlineObjects)
            {
                obj.enabled = false;
                obj.OutlineWidth = 0;
            }

    }
    public void DisableObject()
    {
        gameObject.SetActive(false);
    }

}