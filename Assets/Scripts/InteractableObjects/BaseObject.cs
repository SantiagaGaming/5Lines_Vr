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
    protected CanvasController canvas;
    [SerializeField] protected OutlineCore outlineObject;
    public bool IsHoverable { get; set; } = true;
    public bool IsClickable { get; set; } = true;

    protected Color _objectColor;
    protected Color _hoverColor;
    protected float timer = 2;
    protected virtual void Start()
    {
        canvas = FindObjectOfType<CanvasController>();
    }

    public virtual void OnClicked(InteractHand interactHand)
    {

    }
    public virtual void OnHoverIn(InteractHand interactHand)
    {
        if (outlineObject != null)
            outlineObject.OutlineWidth = 3;
        StartCoroutine("GetObjectName");
    }
    public virtual void OnHoverOut(InteractHand interactHand)
    {
        if (outlineObject != null)
            outlineObject.OutlineWidth = 0;
        timer = 2;
        StopCoroutine("GetObjectName");
        canvas.SetMeasureText("");
    }
    protected IEnumerator GetObjectName()
    {
        yield return new WaitForSeconds(timer);
        canvas.SetMeasureText(gameObject.name);
    }

}