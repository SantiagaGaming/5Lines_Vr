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
    [SerializeField] protected Ampermetr _amper;
    [SerializeField] protected GameObject _map;
    [SerializeField] protected GameObject _helpImage;
    [SerializeField] protected ZoomController _zoomController;
    [SerializeField] protected Transform _dietPosition;
    [SerializeField] protected Transform _amperPosition;
    [SerializeField] protected TextMesh _textMesh;
    [SerializeField] protected GameObject _portal;
    [SerializeField] private GameObject[] _objectsWithButtons;
    [SerializeField] private GameObject[] _actionButtons;

    private bool _canMeaseure = true;

    protected CanvasController canvasController;

    private void Start()
    {
        canvasController = FindObjectOfType<CanvasController>();
        EnableObjectsColliders(false);
    }

    public virtual void DisableCanvas()
    {
        _canvas.SetActive(false);
        gameObject.GetComponent<Collider>().enabled = true;
        _diet.EnableDiet(false, _dietPosition);
        _amper.EnableAmper(false, _amperPosition);
        _map.SetActive(false);
        _helpImage.SetActive(false);
        _zoomController.ResetZoomCamera();
        _portal.SetActive(true);
        EnableObjectsColliders(false);
    }
    public virtual void OnClicked(InteractHand interactHand)
    {
        if(canvasController.CanSwitch)
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
        _portal.SetActive(false);
        EnableObjectsColliders(true);
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
    public Transform GetAmperPosition()
    {
        return _amperPosition;
    }
    public void DisaleActionButtons()
    {
        if (_actionButtons != null)
        {
            foreach (var item in _actionButtons)
            {
                item.SetActive(false);
            }
        }
    }

    public void EnableObjectsColliders(bool value)
    {
        if (_objectsWithButtons != null)
        {
            foreach (var item in _objectsWithButtons)
            {
                item.GetComponent<Collider>().enabled = value;
            }
        }
    }

    public void EnableMeasure(bool value)
    {
        _canMeaseure = value;
    }
    public bool GetMeasureValue()
    {
        return _canMeaseure;
    }

    public bool IsHoverable { get; set; } = true;

    public bool IsClickable { get; set; } = true;
}

