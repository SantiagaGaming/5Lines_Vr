using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Player;
using UnityEngine.Events;

public class CanvasController : MonoBehaviour
{
    public UnityAction CloseObjectEvent;

    [SerializeField] private CanvasObject[] _objectsWithActions;
    [SerializeField] private BackButtonObject[] _backButtonObjects;
    [SerializeField] private LocationController _locationController;

    [HideInInspector] public bool CanSwitch = true;

    private ICanvasObject _currentCanvas;
    private TextMesh _textToShowInCanvas;

    private void Awake()
    {
        foreach (var canvasObject in _objectsWithActions)
        {
            canvasObject.EnableCanvasEvent += OnEnableObjectCanvas;
            canvasObject.GetLocationNameEvent += OnSetLocationName;
        }
        foreach (var back in _backButtonObjects)
        {
            back.BackButtonClickEvent += OnDisableObjectCanvas;
        }
    }

    private void OnEnableObjectCanvas(ICanvasObject canvasObject)
    {
       _currentCanvas = canvasObject;
        ColliderEnabler(false);
    }
    private void OnDisableObjectCanvas()
    {
        _currentCanvas.DisableCanvas();
        MovingButtonsController.Instance.HideAllButtons();
        ShupController shup = FindObjectOfType<ShupController>();
        shup.ResetShupPosition();
        ColliderEnabler(true);
        CloseObjectEvent?.Invoke();
    }

    public bool CompareObjects(ICanvasObject obj)
    {
        if (obj.Equals(_currentCanvas))
            return true;
        else return false;
    }
    private void ColliderEnabler(bool value)
    {
        foreach (var canvasObject in _objectsWithActions)
        {
            canvasObject.GetComponent<Collider>().enabled = value;
        }
    }
    public void SetMeasureText(string text)
    {
        if(_textToShowInCanvas!=null)
        _textToShowInCanvas.text = text;
    }
    public void DisableActionButtons()
    {
        _currentCanvas.DisaleActionButtons();
    }
    public void EnableCanvasObjectsColliders(bool value)
    {
        _currentCanvas.EnableObjectsColliders(value);
    }
    public void EnbaleMeasureActions(bool value)
    {
        _currentCanvas.EnableMeasure(value);
    }
    private void OnSetLocationName(string name, bool value)
    {
        if(value)
            _locationController.SetLocationText(name);
        else
            _locationController.SetPreviousLocation(name);
    }
}
