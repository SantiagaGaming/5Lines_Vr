using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvasController : MonoBehaviour
{
    [SerializeField] private PlayerCanvasViev _viev;
    [SerializeField] private Timer _timer;
    [SerializeField] private ZoomController _zoomController;
    [SerializeField] private SoundPlayer _soundPlayer;
    [SerializeField] private ShupController _shup;
    [SerializeField] private CanvasController _canvasController;
    [SerializeField] private TextMesh _textToShow;

    private void Update()
    {
        _viev.ShowTimerText(_timer.ReturnTime());
    }
    private void OnEnable()
    {
    }
    private void OnDisable()
    {

    }
    public void ControlTimer(bool value)
    {
        _timer.ControlTime(value);
    }





}

