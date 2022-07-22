using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "���������� ������� ������")]

public class AosButtonsHandler : AosObjectBase
{

    [AosEvent(name: "���� �� ������ ��������")]
    public event AosEventHandlerWithAttribute OnAdjustClicked;
    [AosEvent(name: "���� �� ������ �������")]
    public event AosEventHandlerWithAttribute OnWatchClicked;
    [AosEvent(name: "���� �� ������ ������")]
    public event AosEventHandlerWithAttribute OnRepairClicked;
    public void AdjustClicked(string name)
    {
        OnAdjustClicked?.Invoke(name);
    }
    public void WatchClicked(string name)
    {
        OnWatchClicked?.Invoke(name);
    }
    public void RepairClicked(string name)
    {
        OnRepairClicked?.Invoke(name);
    }

}

