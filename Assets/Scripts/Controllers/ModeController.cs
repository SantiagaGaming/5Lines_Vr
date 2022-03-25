using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeController : MonoBehaviour
{
    [SerializeField] private GameObject _desktopPlayer;
    [SerializeField] private GameObject []_zoomButtons;
    private void Start()
    {
        if (!_desktopPlayer.activeSelf)
        {
            foreach (var item in _zoomButtons)
            {
                item.SetActive(false);
            }
        }
          
    }
}
