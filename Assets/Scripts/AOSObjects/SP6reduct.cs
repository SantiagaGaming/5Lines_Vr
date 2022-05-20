using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "СП6 Редуктор")]
public class SP6reduct : AosObjectBase
{
    [AosEvent(name: "Игрок навел курсор на объект")]
    public event AosEventHandlerWithAttribute OnHoverInAOSEvent;
    [AosEvent(name: "Игрок отвел курсор от объекта")]
    public event AosEventHandlerWithAttribute OnHoverOutAOSEvent;
    [AosEvent(name: "Игрок кликнул на объект")]
    public event AosEventHandlerWithAttribute OnClickAOSEvent;

    [SerializeField] private MovebleObject _sp6Reduct;
    [SerializeField] private BaseObject _baseObject;
    private void Awake()
    {
        _baseObject.OnHoverInEvent += OnHoverIn;
        _baseObject.OnHoverOutEvent += OnHoverOut;
        _baseObject.OnClickEvent += OnClick;
    }

    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        _sp6Reduct.SetCondition(value);
    }

    [AosAction(name: "Проиграть анимацию починки объекта со сменой состояния на исправен")]
    public void RepairReduct()
    {
        _sp6Reduct.RepairObject();
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
