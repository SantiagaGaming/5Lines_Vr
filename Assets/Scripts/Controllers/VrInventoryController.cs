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
    //private void Update()
    //{
    //    transform.position = new Vector3(_vrLeftHand.position.x, _vrLeftHand.position.y + 0.046f, _vrLeftHand.position.z - 0.09f);
    //    transform.rotation= _vrLeftHand.ro ;
    //}
}
