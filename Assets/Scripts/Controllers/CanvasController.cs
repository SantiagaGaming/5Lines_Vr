using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Player;
using UnityEngine.Events;

public class CanvasController : MonoBehaviour
{
    public UnityAction CloseObjectEvent;

    [SerializeField] private CanvasObject[] _objectsWithActions;
    [SerializeField] private BackButtonObject[] _backButtonObjects;

    [HideInInspector] public bool CanSwitch = true;

    private ICanvasObject _currentCanvas;
    private TextMesh _textToShowInCanvas;

    private void Awake()
    {
        foreach (var switchCameraObject in _objectsWithActions)
        {
            switchCameraObject.EnableCanvasEvent += OnEnableObjectCanvas;
        }
        foreach (var back in _backButtonObjects)
        {
            back.BackButtonClickEvent += OnDisableObjectCanvas;
        }
    }

    private void OnEnableObjectCanvas(ICanvasObject canvasObject, TextMesh textMesh)
    {
       _currentCanvas = canvasObject;
        ColliderEnabler(false);
        _textToShowInCanvas = textMesh;
    }
    private void OnDisableObjectCanvas()
    {
        foreach (var canvas in _objectsWithActions)
        {
            canvas.DisableCanvas();
        }
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
        _textToShowInCanvas.text = text;
    }
}
