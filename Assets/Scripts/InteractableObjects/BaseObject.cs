using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class BaseObject : MonoBehaviour, IClickAble, IHoverAble
{
    protected CanvasController canvas;
    public bool IsHoverable { get; set; } = true;
    public bool IsClickable { get; set; } = true;

    protected Color _objectColor;
    protected Color _hoverColor;
    protected float timer = 2;
    protected void Start()
    {
        if(GetComponent<Renderer>())
        _objectColor = GetComponent<Renderer>().material.color;
        else
            _objectColor= GetComponentInChildren<Renderer>().material.color;
        _hoverColor = new Color(0.05202916f, 0.6003655f, 0.745283f);
        canvas = FindObjectOfType<CanvasController>();
    }

    public virtual void OnClicked(InteractHand interactHand)
    {
        
    }
    public virtual void OnHoverIn(InteractHand interactHand)
    {
        if (GetComponent<Renderer>())
            GetComponent<Renderer>().material.color = _hoverColor;
        else if (GetComponentInChildren<Renderer>())
            GetComponentInChildren<Renderer>().material.color = _hoverColor;
        else if (GetComponentInParent<Renderer>())
            GetComponentInParent<Renderer>().material.color = _hoverColor;
        else return;
        StartCoroutine("GetObjectName");
    }
    public virtual void OnHoverOut(InteractHand interactHand)
    {
        if (GetComponent<Renderer>())
            GetComponent<Renderer>().material.color = _objectColor;
        else if (GetComponentInChildren<Renderer>())
            GetComponentInChildren<Renderer>().material.color = _objectColor;
        else if (GetComponentInParent<Renderer>())
            GetComponentInParent<Renderer>().material.color = _objectColor;
        else return;
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
