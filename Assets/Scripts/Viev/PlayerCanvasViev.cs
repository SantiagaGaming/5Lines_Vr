using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class PlayerCanvasViev : MonoBehaviour
{
    public UnityAction<bool> RadioButtonTapEvent;
    public UnityAction<bool> StrekaButtonTapEvent;

    [SerializeField] private GameObject _zoomIcon;
    [SerializeField] private GameObject _mapImage;
    [SerializeField] private GameObject _mapIcon;
    [SerializeField] private GameObject _radioImage;
    [SerializeField] private GameObject _radioIcon;
    [SerializeField] private GameObject _helpImage;
    [SerializeField] private GameObject _helpIcon;
    [SerializeField] private GameObject _measureIcon;

    [SerializeField] private Text _measureText;
    [SerializeField] private Text _timerText;

    [SerializeField] private Button _strelkaPlusButton;
    [SerializeField] private Button _strelakMinusButton;
    private void Start()
    {
        _strelkaPlusButton.onClick.AddListener(() => { StrekaButtonTapEvent?.Invoke(true); });
        _strelakMinusButton.onClick.AddListener(() => { StrekaButtonTapEvent?.Invoke(false); });
    }

    public void ShowTimerText(string time)
    {
        _timerText.text = time;
    }
    public void ShowZoomImage(bool value)
    {
        _zoomIcon.SetActive(value);
    }
    public void ShowMapImage(bool value)
    {
        _mapIcon.SetActive(value);
        _mapImage.SetActive(value);
    }

    public void ShowRadioImage(bool value)
    {
        _radioImage.SetActive(value);
        _radioIcon.SetActive(value);
    }
    public void ShowHelpImage(bool value)
    {
        _helpImage.SetActive(value);
        _helpIcon.SetActive(value);
    }
    public void ShowMeasureText(string text)
    {
        if(_measureText.text =="")
        {
            _measureIcon.SetActive(false);
        }
        else
        {
            _measureIcon.SetActive(true);
        }
        _measureText.text = text;

    }

}
