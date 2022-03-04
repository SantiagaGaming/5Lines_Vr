using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInventController : MonoBehaviour
{
    public UnityAction<bool> CameraEvent;
    public UnityAction MapEvent;
    public UnityAction RadioEvent;
    public UnityAction HelpEvent;

    [SerializeField] private Camera _playerCamera;

    [SerializeField] private InputActionProperty _camera;
    [SerializeField] private InputActionProperty _map;
    [SerializeField] private InputActionProperty _radio;
    [SerializeField] private InputActionProperty _help;

    private bool _cameraSwitched = false;
    private bool _showMaped = false;
    private bool _showRadio = false;
    private bool _showHelped = false;
    private void OnEnable()
    {
        _camera.action.performed += _ => _cameraSwitched = true;
        _map.action.performed += _ => _showMaped = true;
        _radio.action.performed += _ => _showRadio = true;
        _help.action.performed += _ => _showHelped = true;
    }
    private void Update()
    {
       if(_cameraSwitched == true)
        {
            if (_playerCamera.fieldOfView == 60)
            {
                _playerCamera.fieldOfView = 15;
                CameraEvent?.Invoke(true);
            }
            else
            {
                _playerCamera.fieldOfView = 60;
                CameraEvent?.Invoke(false);
            }
            
            _cameraSwitched = false;
        }
       if(_showMaped ==true)
        {
            MapEvent?.Invoke();
            _showMaped = false;
        }
        if (_showRadio == true)
        {
            RadioEvent?.Invoke();
            _showRadio = false;
        }
        if (_showHelped == true)
        {
            HelpEvent?.Invoke();
            _showHelped = false;
        }
    }

}
