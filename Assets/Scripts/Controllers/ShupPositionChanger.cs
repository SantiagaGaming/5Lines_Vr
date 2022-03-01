using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShupPositionChanger : MonoBehaviour
{
    [SerializeField] private ShupController _shupController;
    [SerializeField] private MeasureButton[] _measureButtons;
    private void Start()
    {
        foreach (var measureButton in _measureButtons)
        {
            measureButton.MeasureButtonClickEvent += OnSetNewShupPositon;
        }
    }
    private void OnSetNewShupPositon(Transform pos, string name)
    {
        _shupController.SetShupPosition(pos, name);
    }
}
