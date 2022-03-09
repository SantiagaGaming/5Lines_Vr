using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrelkaContoller : MonoBehaviour
{
    [SerializeField] private PlayerCanvasViev _playerCanvasViev;
    [SerializeField] private StrelkaAOS _strelkaAOS;

    private void OnEnable()
    {
        _playerCanvasViev.StrekaButtonTapEvent += OnStrelkaSwitch;
    }
    private void OnDisable()
    {
        _playerCanvasViev.StrekaButtonTapEvent -= OnStrelkaSwitch;

    }

    public void OnStrelkaSwitch(bool value)
    {
        _strelkaAOS.TrySwitchStrelka(value);
    }
}
