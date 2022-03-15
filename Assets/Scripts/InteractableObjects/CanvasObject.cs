using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class CanvasObject : MonoBehaviour, IClickAble, IHoverAble, ICanvasObject
{
    public UnityAction<ICanvasObject, TextMesh> EnableCanvasEvent;

    [SerializeField] protected GameObject _canvas;
    [SerializeField] protected GameObject _canIterractSign;
    [SerializeField] protected Diet _diet;
    [SerializeField] protected GameObject _map;
    [SerializeField] protected GameObject _helpImage;
    [SerializeField] protected ZoomController _zoomController;
    [SerializeField] protected Transform _dietPosition;
    [SerializeField] protected TextMesh _textMesh;

    protected CanvasController _cameraSwitch;

    private void Start()
    {
        _cameraSwitch = FindObjectOfType<CanvasController>();
    }

    public virtual void DisableCanvas()
    {
        _canvas.SetActive(false);
        gameObject.GetComponent<Collider>().enabled = true;
        _diet.EnableDiet(false, _dietPosition);
        _map.SetActive(false);
        _helpImage.SetActive(false);
        _zoomController.ResetZoomCamera();
    }
    public virtual void OnClicked(InteractHand interactHand)
    {
        if(_cameraSwitch.CanSwitch)
        {
            ShowCanvas();
            _canIterractSign.SetActive(false);
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
    protected void ShowCanvas()
    {
        _canvas.SetActive(true);
        EnableCanvasEvent?.Invoke(this,_textMesh);
    }

    public void OnHoverIn(InteractHand interactHand)
    {
        _canIterractSign.SetActive(true);
    }
    public void OnHoverOut(InteractHand interactHand)
    {
        _canIterractSign.SetActive(false);
    }
    public Transform GetDietPosition()
    {
        return _dietPosition;
    }
    public bool IsHoverable { get; set; } = true;

    public bool IsClickable { get; set; } = true;
}

