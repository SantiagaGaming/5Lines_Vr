using System.Collections;
using AosSdk.Core.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "Block3SP6")]
public class Block3_SP6 : AosObjectBase
{
    [SerializeField] private GameObject _brokenBlock;
    [SerializeField] private GameObject _serviceableBlock;
    [Space]
    [SerializeField] private GameObject _brokenContact;
    [SerializeField] private GameObject _serviceableContact;

    [AosAction(name: "Сменить состояние объекта true - исправен, false - неисправен")]
    public void SetCondition(bool value)
    {
        if (value)
        {
            _brokenBlock.SetActive(false);
            _serviceableBlock.SetActive(true);
        }
        else
        {
            _brokenBlock.SetActive(true);
            _serviceableBlock.SetActive(false);
        }
    }
    [AosAction(name: "Сменить состояние конакта объекта true - исправен, false - неисправен")]
    public void SetConactCondition(bool value)
    {
        if (value)
        {
            _brokenContact.SetActive(false);
            _serviceableContact.SetActive(true);
        }
        else
        {
            _brokenContact.SetActive(true);
            _serviceableContact.SetActive(false);
        }
    }

}