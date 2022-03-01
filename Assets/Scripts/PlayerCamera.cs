using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCamera : MonoBehaviour
{
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
                _playerCamera.fieldOfView = 15;
            else
                _playerCamera.fieldOfView = 60;
            _cameraSwitched = false;
        }
    }

}
