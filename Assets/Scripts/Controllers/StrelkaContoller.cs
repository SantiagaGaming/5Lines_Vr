using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrelkaContoller : MonoBehaviour
{
    [SerializeField] private StrelkaButton[] _strelkas;
    [SerializeField] private PlayerCanvasViev _playerCanvasViev;

    private void Awake()
    {
        foreach (var strelka in _strelkas)
        {
            strelka.StrelkaButtonClickEvent += OnStrelkaSwitched;
        }

    }
    private void OnEnable()
    {
        _playerCanvasViev.StrekaButtonTapEvent += OnStrelkaSwitched;
    }
    private void OnDisable()
    {
        _playerCanvasViev.StrekaButtonTapEvent -= OnStrelkaSwitched;
    }
    private void OnStrelkaSwitched(bool value)
    {
        print(value+ "Состояние");
    }
}
