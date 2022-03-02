using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] private PlayerCanvasViev _viev;
    [SerializeField] private Timer _timer;
    [SerializeField] private PlayerCamera _playerCamera;

    private void Update()
    {
        _viev.ShowTimerText(_timer.ReturnTime());
    }
    private void OnEnable()
    {
        _playerCamera.CameraZoomEvent += OnZoomImageEnabler;
    }
    private void OnDisable()
    {
        _playerCamera.CameraZoomEvent -= OnZoomImageEnabler;
    }
    public void ControlTimer(bool value)
    {
        _timer.ControlTime(value);
    }

    private void OnZoomImageEnabler(bool value)
    {
        _viev.ShowZoomImage(value);
    }
}
