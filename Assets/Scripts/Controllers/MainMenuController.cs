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
    [SerializeField] private GameObject _canvas;
    [SerializeField] private TeleportController _teleportController;
    [Space]
    [SerializeField] private Transform _streetCanvasPosition;
    [SerializeField] private Transform _koredCanvasPosition;
    [SerializeField] private Transform _dspCanvasPosition;
    [SerializeField] private Transform _releCanvasPosition;
    [Space]
    [SerializeField] private Transform _streetPlayerPosition;
    [SerializeField] private Transform _koredPlayerPosition;
    [SerializeField] private Transform _dspPlayerPosition;
    [SerializeField] private Transform _relePlayerPosition;

    private Transform _currentPlayerPosition;
    private Transform _currentCanvasPosition;
    private void Awake()
    {
        _currentCanvasPosition = _streetCanvasPosition;
        _currentPlayerPosition = _streetPlayerPosition;
    }
    private void OnEnable()
    {
        _teleportController.TeleportEvent += OnChangeTransforms;
    }
    private void OnDisable()
    {
        _teleportController.TeleportEvent -= OnChangeTransforms;
    }
    public void ShowMainMenu()
    {
        _canvas.transform.position = _currentCanvasPosition.position;
        _canvas.transform.rotation = _currentCanvasPosition.rotation;
        Player.Instance.TeleportTo(_currentPlayerPosition);
        _descPlayer.transform.rotation = _currentPlayerPosition.rotation;
        _vrPlayer.transform.rotation = _currentPlayerPosition.rotation;
        _cameraFlash.CameraFlashStart();
        _canvas.SetActive(true);
        Player.Instance.CanMove = false;
        _teleportController.CanTeleport = false;
    }
    public void HideMainMenu()
    {
        Player.Instance.CanMove = true;
        _canvas.SetActive(false);
        _teleportController.CanTeleport = true;
    }
    public void OnChangeTransforms(string name)
    {
        if(name== "corid_dsp")
        {
            _currentCanvasPosition = _dspCanvasPosition;
            _currentPlayerPosition = _dspPlayerPosition;
        }
        else if(name == "korid_out")
        {
            _currentCanvasPosition = _streetCanvasPosition;
            _currentPlayerPosition = _streetPlayerPosition;
        }
       else if(name == "corid_rele")
        {
            _currentCanvasPosition = _releCanvasPosition;
            _currentPlayerPosition = _relePlayerPosition;
        }
        else if(name == "dsp_door" || name == "rele_door"|| name == "post_door")
        {
            _currentCanvasPosition = _koredCanvasPosition;
            _currentPlayerPosition = _koredPlayerPosition;
        }
    }
}
