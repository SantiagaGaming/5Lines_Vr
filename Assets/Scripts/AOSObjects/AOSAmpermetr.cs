using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;
[AosObject(name: "Амперметр")]
public class AOSAmpermetr : AosObjectBase
{
    [SerializeField] private GameObject _leverArm;
    [AosAction(name: "Изменить переключатель пределов измерений")]
    public void SetCondition(float value)
    {
        if(value<=0.5f)
        _leverArm.transform.localRotation = Quaternion.Euler(0, -135f, 0);
        else if(value<=2.5f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -120f, 0);
        else if (value <= 10f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -105f, 0);
        else if (value <= 25f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -90f, 0);
        else if (value <= 50f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -75f, 0);
        else if (value <= 100f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -60f, 0);
        else if (value <= 250f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -45f, 0);
        else if (value <= 500f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -30f, 0);
        else if (value <= 1000f)
            _leverArm.transform.localRotation = Quaternion.Euler(0, -15f, 0);
    }
}
