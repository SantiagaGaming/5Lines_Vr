using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
public class Bag : MonoBehaviour, IClickAble, IHoverAble
{
    public bool IsHoverable { get; set; } = true;
    public bool IsClickable { get; set; } = true;

    [SerializeField] private GameObject _bagOpen;
    [SerializeField] private GameObject _bagClose;

    private OutlineCore _outlineObject;

    private void Start()
    {
        _outlineObject = _bagClose.GetComponentInChildren<OutlineCore>();
    }

    public virtual void OnClicked(InteractHand interactHand)
    {
     
            _bagOpen.SetActive(true);
            _bagClose.SetActive(false);
           GetComponent<Collider>().enabled = false;
    }
    public virtual void OnHoverIn(InteractHand interactHand)
    {
        if (_outlineObject != null)
            _outlineObject.OutlineWidth = 3;

    }
    public virtual void OnHoverOut(InteractHand interactHand)
    {
        if (_outlineObject != null)
            _outlineObject.OutlineWidth = 0;

    }

}
