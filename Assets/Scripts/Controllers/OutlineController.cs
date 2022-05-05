using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using AosSdk.CustomObjects.OutlineManager;
using AosSdk.ThirdParty.QuickOutline.Scripts;

public class OutlineController : MonoBehaviour
{
    [SerializeField] private OutlineManager _outlineManager;
    private List <OutLineObject> _outlineObjectsList = new List<OutLineObject>();
    private OutlineMode _mode;
    private void Start()
    {  
        _mode = OutlineMode.OutlineAll;
        _outlineManager.SetOutlineDefaultParameters(255, 0, 255, 3, _mode);
        foreach (var item in _outlineObjectsList)
        {
            _outlineManager.OutlineObjectWithDefaultParameters(item.objectStaticGuid);
        }
    }
    public void AddOutlineObject(OutLineObject obj)
    {
        _outlineObjectsList.Add(obj);
    }    
}
