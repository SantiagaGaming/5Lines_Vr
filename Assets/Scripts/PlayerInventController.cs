using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInventController : MonoBehaviour
{
    public UnityAction<bool> CameraZoomEvent;
    public UnityAction ShowMapEvent;

    [SerializeField] private Camera _playerCamera;

    [SerializeField] private InputActionProperty _cameraSwitch;
    [SerializeField] private InputActionProperty _showMap;

    private bool _cameraSwitched = false;
    private bool _showMaped = false;
    private void OnEnable()
    {
        _cameraSwitch.action.performed += _ => _cameraSwitched = true;
        _showMap.action.performed += _ => _showMaped = true;
    }
    private void Update()
    {
       if(_cameraSwitched == true)
        {
            if (_playerCamera.fieldOfView == 60)
            {
                _playerCamera.fieldOfView = 15;
                CameraZoomEvent?.Invoke(true);
            }
            else
            {
                _playerCamera.fieldOfView = 60;
                CameraZoomEvent?.Invoke(false);
            }
            
            _cameraSwitched = false;
        }
       if(_showMaped ==true)
        {
            ShowMapEvent?.Invoke();
            _showMaped = false;
        }
    }

}
