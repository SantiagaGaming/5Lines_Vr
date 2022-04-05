using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalRotator : MonoBehaviour
{
    [SerializeField] private bool _right;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scale;

    private void Start()
    {
        if (!_right) _rotateSpeed = -_rotateSpeed;
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime, Space.World);

        Vector3 vec = new Vector3(Mathf.Sin(Time.time) +_scale, 0.6f, Mathf.Sin(Time.time) +_scale);

        transform.localScale = vec;
    }

}
