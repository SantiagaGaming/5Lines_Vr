using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] private PlayerCanvasViev _viev;
    [SerializeField] private Timer _timer;
    [SerializeField] private PlayerInventController _playerInvent;
    [SerializeField] private SoundPlayer _soundPlayer;
    [SerializeField] private CursorController _mouse;

    private bool _map = false;
    private bool _radio = false;

    private void Update()
    {
        _viev.ShowTimerText(_timer.ReturnTime());
    }
    private void OnEnable()
    {
        _playerInvent.CameraEvent += OnZoomImageEnabler;
        _playerInvent.MapEvent += OnMapShowEnabler;
        _playerInvent.RadioEvent += OnRadioShowEnabler;
    }
    private void OnDisable()
    {
        _playerInvent.CameraEvent -= OnZoomImageEnabler;
        _playerInvent.MapEvent -= OnMapShowEnabler;
        _playerInvent.RadioEvent -= OnRadioShowEnabler;
    }
    public void ControlTimer(bool value)
    {
        _timer.ControlTime(value);
    }

    private void OnZoomImageEnabler(bool value)
    {
        _viev.ShowZoomImage(value);
    }
    private void OnMapShowEnabler()
    {
        if(_map)
        {
            _map = false;
            _soundPlayer.PlayMapCloseSound();
        }
        else
        {
            _map = true;
            _soundPlayer.PlayMapOpenSound();
        }
        _viev.ShowMapImage(_map);
    }

    private void OnRadioShowEnabler()
    {
        if (_radio)
        {
            _radio = false;
            _mouse.SwitchMouse(_radio);
        }
        else
        {
            _radio = true;
            _mouse.SwitchMouse(_radio);
            _soundPlayer.PlayRadioSound();
        }
        _viev.ShowRadioImage(_radio);
    }
}
