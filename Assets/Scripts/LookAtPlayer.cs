using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private ModeController _modeController;
    private Transform _playerPos;
    private void Start()
    {
        _modeController = FindObjectOfType<ModeController>();
        _playerPos = _modeController.GetPlayerTransform();
    }
    private void Update()
    {
        transform.rotation = _playerPos.rotation;
        //transform.LookAt(_playerPos);
    }
}
