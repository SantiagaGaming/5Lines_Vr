using AosSdk.Core.Interaction;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Player.Pointer;
using AosSdk.Core.Utils;
using UnityEngine;

namespace AosSdk.Examples
{
    [AosObject("Пример грабабельного объекта")]
    public class GrabbableExample : AosObjectBase, IGrabbable, IClickAble, IHoverAble
    {
        [SerializeField] private Transform _ugrabPos;
        private OutlineCore _outlineObject;
        [field: SerializeField] public GrabType GrabType { get; set; }

        [field: SerializeField] public Transform GrabAnchor { get; set; }

        public bool IsGrabbable { get; set; } = true;
        public bool IsClickable { get; set; } = true;
        public bool IsHoverable { get; set; } = true;
        public bool IsGrabbed { get; set; }
        private void Start()
        {
            _outlineObject = GetComponent<OutlineCore>();
        }

        public void OnGrabbed(InteractHand interactHand)
        {
            GetComponent<Collider>().isTrigger = false;
            GetComponent<Rigidbody>().isKinematic = false;
            if (_outlineObject != null)
                _outlineObject.OutlineWidth = 0;
        }

        public void OnUnGrabbed(InteractHand interactHand)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = _ugrabPos.position;
            transform.rotation = _ugrabPos.rotation;
            GetComponent<Collider>().isTrigger = true;
        }

        public void OnClicked(InteractHand interactHand)
        {
            Debug.Log("Grabbed was clicked");
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
}