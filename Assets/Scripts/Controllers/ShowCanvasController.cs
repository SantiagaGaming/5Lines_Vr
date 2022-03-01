using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Player;

public class ShowCanvasController : MonoBehaviour
{
    [SerializeField] private ShowCanvasObject[] _objectsWithActions;
    [SerializeField] private BackButtonObject[] _backButtonObjects;

    [HideInInspector] public bool CanSwitch = true;

    private ICanvasObject _currentCanvas;

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

    private void OnEnableObjectCanvas(ICanvasObject canvasObject)
    {
   
           _currentCanvas = canvasObject;
    }
    private void OnDisableObjectCanvas()
    {
        foreach (var canvas in _objectsWithActions)
        {
            canvas.DisableCanvas();
        }
        ShupController shup = FindObjectOfType<ShupController>();
        shup.ResetShupPosition();
    }

    public bool CompareObjects(ICanvasObject obj)
    {
        if (obj.Equals(_currentCanvas))
            return true;
        else return false;
    }
}
