using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;

[AosObject(name: "AosManager")]
public class AosObjectManager : AosObjectBase
{
    [AosEvent(name: "OnClickObject")]
    public event AosEventHandlerWithAttribute OnClickObject;
    public static AosObjectManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    private AosObjectManager(){}


    public void InvokeOnClick(string name)
    {
        OnClickObject?.Invoke(name);
    }

}
