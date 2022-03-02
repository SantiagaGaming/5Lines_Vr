using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCanvasViev : MonoBehaviour
{
    [SerializeField] private Text _interractText;
    [SerializeField] private GameObject _temirImage;
    [SerializeField] private Text _timerText;
    [SerializeField] private GameObject _zoomImage;

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
        _zoomImage.SetActive(value);
    }

}
