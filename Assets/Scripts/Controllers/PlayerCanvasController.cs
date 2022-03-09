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
    [SerializeField] private ShupController _shup;
    [SerializeField] private CanvasController _canvasController;
    [SerializeField] private TextMesh _vrMeasureText;

    private bool _map = false;
    private bool _radio = false;
    private bool _help = false;

    private void Update()
    {
        _viev.ShowTimerText(_timer.ReturnTime());
    }
    private void OnEnable()
    {
        _playerInvent.CameraEvent += OnZoomImageEnabler;
        _playerInvent.MapEvent += OnMapShowEnabler;
        _playerInvent.RadioEvent += OnRadioShowEnabler;
        _playerInvent.HelpEvent += OnHelpShowEnabler;
        //_shup.SetMeasureTextEvent += OnSetMeasureText;
        //_canvasController.CloseObjectEvent += OnClearMeasureText;
    }
    private void OnDisable()
    {
        _playerInvent.CameraEvent -= OnZoomImageEnabler;
        _playerInvent.MapEvent -= OnMapShowEnabler;
        _playerInvent.RadioEvent -= OnRadioShowEnabler;
        _playerInvent.HelpEvent -= OnHelpShowEnabler;
        //_shup.SetMeasureTextEvent -= OnSetMeasureText;
        //_canvasController.CloseObjectEvent -= OnClearMeasureText;
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
    private void OnHelpShowEnabler()
    {
        if (_help)
        {
            _help = false;
            _mouse.SwitchMouse(_help);
        }
        else
        {
           _help = true;
            _mouse.SwitchMouse(_help);
        }
        _viev.ShowHelpImage(_help);
    }
    private void OnClearMeasureText()
    {
        _viev.ShowMeasureText("");
        _vrMeasureText.text = "";
    }
    public void SetMeasureText(string text)
    {
        _viev.ShowMeasureText(text);
        _vrMeasureText.text = text;
    }
    public void MeasureIconEnabler(bool value)
    {
        _viev.ShowMeasureIcon(value);
    }
}

