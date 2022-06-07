using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocationController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _deskText;
    [SerializeField] private TextMeshProUGUI _textMesh;
    private string _previousLocation;
    private void Start()
    {
        _deskText.text = "Поле";
        _textMesh.text = "Поле";
    }
    public void SetLocationText(string location)
    {
        _deskText.text = location;
        _textMesh.text = location;
    }
    public void SetPreviousLocation(string currentLocation)
    {
  
        if (currentLocation == "Муфта УПМ-24" || currentLocation == "Электропривод")
            SetLocationText("Привод");
        else if (currentLocation == "Фартук привода" || currentLocation == "Рабочая тяга" || currentLocation == "Остряк слева" || currentLocation == "Остряк справа")
            SetLocationText("Перевод");
        else if (currentLocation == "Лицевая часть пульт-табло" || currentLocation == "Монтажная часть пульт-табло")
            SetLocationText("Помещение ДСП");
        else if(currentLocation == "Статив 14 (лицевая)" || currentLocation == "Статив 14 (монтаж)")
            SetLocationText("Релейная");
    }

}
