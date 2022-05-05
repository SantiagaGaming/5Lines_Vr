using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{
    [SerializeField] private OutlineCore _sp6Roof;
    [SerializeField] private OutlineCore _sp6Privod;
    [SerializeField] private OutlineCore _muftaRoof;
    [SerializeField] private OutlineCore _muftaPrivod;
    [SerializeField] private OutlineCore _railLeft;
    [SerializeField] private OutlineCore _railRight;
    [SerializeField] private OutlineCore _streetDoor;

    [SerializeField] private OutlineCore _fromKorridorToStreetDoor;
    [SerializeField] private OutlineCore _fromKorridorToReleDoor;
    [SerializeField] private OutlineCore _fromKorridorToDspDoor;

    [SerializeField] private OutlineCore _fromDspToKorridorDoor;
    [SerializeField] private OutlineCore _dspObject;

    [SerializeField] private OutlineCore _fromReleToKorridoorDoor;
    [SerializeField] private OutlineCore _releObject;



}
