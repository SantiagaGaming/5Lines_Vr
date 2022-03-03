using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerCanvasViev : MonoBehaviour
{
    public UnityAction<bool> RadioButtonTapEvent;

    [SerializeField] private Text _interractText;
    [SerializeField] private Text _timerText;
    [SerializeField] private GameObject _timerImage;
    [SerializeField] private GameObject _zoomIcon;
    [SerializeField] private GameObject _mapImage;
    [SerializeField] private GameObject _mapIcon;
    [SerializeField] private GameObject _radioImage;
    [SerializeField] private GameObject _radioIcon;

    public void ShowInterractText(string value)
    {
        _interractText.text = value;
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

}
