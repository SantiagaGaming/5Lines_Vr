using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "���")]
public class Nmsh : AosObjectBase
{
    [AosEvent(name: "����� ����� ������ �� ������")]
    public event AosEventHandlerWithAttribute OnHoverInAOSEvent;
    [AosEvent(name: "����� ����� ������ �� �������")]
    public event AosEventHandlerWithAttribute OnHoverOutAOSEvent;
    [AosEvent(name: "����� ������� �� ������")]
    public event AosEventHandlerWithAttribute OnClickAOSEvent;
    [SerializeField] private MovebleObject _nmsh;
    [SerializeField] private BaseObject _baseObject;
    private void Awake()
    {
        _baseObject.OnHoverInEvent += OnHoverIn;
        _baseObject.OnHoverOutEvent += OnHoverOut;
        _baseObject.OnClickEvent += OnClick;
    }

    [AosAction(name: "������� ��������� ������� true - ��������, false - ����������")]
    public void SetCondition(bool value)
    {
        _nmsh.SetCondition(value);
    }

    [AosAction(name: "��������� �������� ������� ������� �� ������ ��������� �� ��������")]
    public void RepairNmsh()
    {
        _nmsh.RepairObject();
    }
    public void OnHoverIn(string name)
    {
        OnHoverInAOSEvent?.Invoke(name);
    }
    public void OnHoverOut(string name)
    {
        OnHoverOutAOSEvent?.Invoke(name);
    }
    public void OnClick(string name)
    {
        OnClickAOSEvent?.Invoke(name);
    }

}
