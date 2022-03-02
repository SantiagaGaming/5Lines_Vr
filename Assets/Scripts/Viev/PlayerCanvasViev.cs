using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvasViev : MonoBehaviour
{
    [SerializeField] private Text _interractText;
    [SerializeField] private GameObject _temirImage;
    [SerializeField] private Text _timerText;
    [SerializeField] private GameObject _zoomIcon;
    [SerializeField] private GameObject _mapImage;
    [SerializeField] private GameObject _mapIcon;

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

}
