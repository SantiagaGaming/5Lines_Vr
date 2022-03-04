using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VrInventoryController : MonoBehaviour
{
    [SerializeField] private Transform _vrLeftHand;
    [SerializeField] private GameObject _vrPlayer;
    private void Start()
    {
        if (_vrPlayer.activeSelf)
        {
            transform.SetParent(_vrLeftHand);
            return;
        }
        else
            gameObject.SetActive(false);
    }
}
