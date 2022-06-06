using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private GameObject _descPlayer;
    [SerializeField] private GameObject _vrPlayer;
    [Space]
    [SerializeField] private CameraFlash _cameraFlash;
    [Space]
    [SerializeField] private ModeController _modeController;
    [SerializeField] private Transform _menuPosition;

    private Vector3 _currentPlayerPosition = new Vector3();

    public void ShowMainMenu()
    {
        _currentPlayerPosition = new Vector3(_modeController.GetPlayerTransform().position.x, 0.1500001f, _modeController.GetPlayerTransform().position.z);
        Player.Instance.TeleportTo(_menuPosition);
        _descPlayer.transform.rotation = _menuPosition.rotation;
        _vrPlayer.transform.rotation = _menuPosition.rotation;
        _cameraFlash.CameraFlashStart();
    }
    public void HideMainMenu()
    {
        _cameraFlash.CameraFlashStart();
        Player.Instance.TeleportTo(_currentPlayerPosition);
    }
}
