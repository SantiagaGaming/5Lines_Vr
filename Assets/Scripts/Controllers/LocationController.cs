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
        _deskText.text = "����";
        _textMesh.text = "����";
    }
    public void SetLocationText(string location)
    {
        _deskText.text = location;
        _textMesh.text = location;
    }
    public void SetPreviousLocation(string currentLocation)
    {
  
        if (currentLocation == "����� ���-24" || currentLocation == "�������������")
            SetLocationText("������");
        else if (currentLocation == "������ �������" || currentLocation == "������� ����" || currentLocation == "������ �����" || currentLocation == "������ ������")
            SetLocationText("�������");
        else if (currentLocation == "������� ����� �����-�����" || currentLocation == "��������� ����� �����-�����")
            SetLocationText("��������� ���");
        else if(currentLocation == "������ 14 (�������)" || currentLocation == "������ 14 (������)")
            SetLocationText("��������");
    }

}
