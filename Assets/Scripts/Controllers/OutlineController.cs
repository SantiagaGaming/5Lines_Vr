using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineController : MonoBehaviour
{
    [SerializeField] private TeleportController _teleportController;
    [Space]
    [SerializeField] private GameObject _sp6Roof;
    [SerializeField] private GameObject _sp6Privod;
    [SerializeField] private GameObject _muftaRoof;
    [SerializeField] private GameObject _muftaPrivod;
    [SerializeField] private GameObject _fartuk;
    [SerializeField] private GameObject _railLeft;
    [SerializeField] private GameObject _railRight;
    [SerializeField] private GameObject _streetDoor;

    [SerializeField] private GameObject _fromKorridorToStreetDoor;
    [SerializeField] private GameObject _fromKorridorToReleDoor;
    [SerializeField] private GameObject _fromKorridorToDspDoor;

    [SerializeField] private GameObject _fromDspToKorridorDoor;
    [SerializeField] private GameObject _dspObject;

    [SerializeField] private GameObject _fromReleToKorridoorDoor;
    [SerializeField] private GameObject _releObject;
    private void Start()
    {
        DisableOutline();
        OutlineEnabler("korid_out");

    }
    private void OnEnable()
    {
        _teleportController.TeleportEvent += OnTeleport;
    }
    private void OnDisable()
    {
        _teleportController.TeleportEvent -= OnTeleport;
    }

    private void OnTeleport(string name)
    {
        DisableOutline();
        OutlineEnabler(name);
    }
    private void OutlineEnabler(string name)
    {
        if(name ==  "post_door" || name == "dsp_door" || name == "rele_door")
        {
            _fromKorridorToStreetDoor.GetComponent<OutlineCore>().enabled = true;
            _fromKorridorToReleDoor.GetComponent<OutlineCore>().enabled = true;
            _fromKorridorToDspDoor.GetComponent<OutlineCore>().enabled = true;
        }
        else if(name == "korid_out" )
        {
            _sp6Roof.GetComponent<OutlineCore>().enabled = true;
             _sp6Privod.GetComponent<OutlineCore>().enabled = true;
             _muftaRoof.GetComponent<OutlineCore>().enabled = true;
            _muftaPrivod.GetComponent<OutlineCore>().enabled = true;
            _fartuk.GetComponent<OutlineCore>().enabled = true;
            _railLeft.GetComponent<OutlineCore>().enabled = true;
            _railRight.GetComponent<OutlineCore>().enabled = true;
            _streetDoor.GetComponent<OutlineCore>().enabled = true;
        }
        else if(name == "corid_rele")
        {
            _fromReleToKorridoorDoor.GetComponent<OutlineCore>().enabled = true;
             _releObject.GetComponent<OutlineCore>().enabled = true;
        }
        else if(name == "corid_dsp")
        {
            _fromDspToKorridorDoor.GetComponent<OutlineCore>().enabled = true;
             _dspObject.GetComponent<OutlineCore>().enabled = true;
        }
    }
    private void DisableOutline()
    {
        _sp6Roof.GetComponent<OutlineCore>().enabled = false;
        _sp6Privod.GetComponent<OutlineCore>().enabled = false;
        _muftaRoof.GetComponent<OutlineCore>().enabled = false;
        _muftaPrivod.GetComponent<OutlineCore>().enabled = false;
        _railLeft.GetComponent<OutlineCore>().enabled = false;
        _railRight.GetComponent<OutlineCore>().enabled = false;
        _streetDoor.GetComponent<OutlineCore>().enabled = false;
        _fromKorridorToStreetDoor.GetComponent<OutlineCore>().enabled = false;
        _fromKorridorToReleDoor.GetComponent<OutlineCore>().enabled = false;
        _fromKorridorToDspDoor.GetComponent<OutlineCore>().enabled = false;
        _fromDspToKorridorDoor.GetComponent<OutlineCore>().enabled = false;
        _dspObject.GetComponent<OutlineCore>().enabled = false;
        _fromReleToKorridoorDoor.GetComponent<OutlineCore>().enabled = false;
        _releObject.GetComponent<OutlineCore>().enabled = false;
        _fartuk.GetComponent<OutlineCore>().enabled = false;
    }




}
