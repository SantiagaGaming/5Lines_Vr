using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] private PlayerCanvasViev _viev;
    [SerializeField] private Timer _timer;
    [SerializeField] private PlayerInventController _playerInvent;
    [SerializeField] private SoundPlayer _soundPlayer;

    private bool _map =false;

    private void Update()
    {
        _viev.ShowTimerText(_timer.ReturnTime());
    }
    private void OnEnable()
    {
        _playerInvent.CameraZoomEvent += OnZoomImageEnabler;
        _playerInvent.ShowMapEvent += OnMapShowEnabler;
    }
    private void OnDisable()
    {
        _playerInvent.CameraZoomEvent -= OnZoomImageEnabler;
        _playerInvent.ShowMapEvent -= OnMapShowEnabler;
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
}
