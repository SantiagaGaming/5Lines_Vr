using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] private bool _rot;
    private ModeController _modeController;
    private Transform _playerPos;
    private void Start()
    {
        _modeController = FindObjectOfType<ModeController>();
        _playerPos = _modeController.GetPlayerTransform();
    }
    private void Update()
    {
        //
        //transform.LookAt(_playerPos);
        if(!_rot)
        transform.rotation = Quaternion.LookRotation(transform.position - _playerPos.position);
        else
            transform.rotation = _playerPos.rotation;
    }
}
