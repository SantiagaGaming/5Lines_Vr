using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerCamera : MonoBehaviour
{
    public UnityAction<bool> CameraZoomEvent;
    [SerializeField] private Camera _playerCamera;

    [SerializeField] private InputActionProperty _cameraSwitch;

    private bool _cameraSwitched = false;
    private void OnEnable()
    {
        _cameraSwitch.action.performed += _ => _cameraSwitched = true;
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
    }

}
