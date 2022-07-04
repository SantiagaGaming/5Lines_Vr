using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;
using AosSdk.ThirdParty.QuickOutline.Scripts;

public class CanvasObject :BaseObject, ICanvasObject
{
    public UnityAction<ICanvasObject> EnableCanvasEvent;

    public UnityAction<string, bool> GetLocationNameEvent;
    [SerializeField] protected GameObject _canvas;
    [SerializeField] protected GameObject _canIterractSign;
    [SerializeField] protected Diet _diet;
    [SerializeField] protected Ampermetr _amper;
    [SerializeField] protected GameObject _map;
    [SerializeField] protected Transform _dietPosition;
    [SerializeField] protected Transform _amperPosition;
   // [SerializeField] protected TextMesh _textMesh;
    [SerializeField] protected string _locationName;


    [SerializeField] private GameObject[] _objectsWithButtons;


    private bool _canMeaseure = true;


    override protected void Start()
    {
        base.Start();
        EnableObjectsColliders(false);
    }

    public virtual void DisableCanvas()
    {
        _canvas.SetActive(false);
        gameObject.GetComponent<Collider>().enabled = true;
        _diet.EnableDiet(false, _dietPosition);
        _amper.EnableAmper(false, _amperPosition);
        _map.SetActive(false);
        EnableObjectsColliders(false);
        DisaleActionButtons();
        GetLocationNameEvent?.Invoke(_locationName,false);
        if (outlineObjects != null)
        {
            foreach (var obj in outlineObjects)
            {
                obj.enabled = true;
            }
        }

    }
    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        if (canvasController.CanSwitch)
        {
            ShowCanvas();
            EnableCanvasEvent?.Invoke(this);
            _canIterractSign.SetActive(false);
            gameObject.GetComponent<Collider>().enabled = false;
            if (outlineObjects != null)
                foreach (var obj in outlineObjects)
                {
                    obj.enabled = false;
                }
            GetLocationNameEvent?.Invoke(_locationName,true);
        }
    }
    protected void ShowCanvas()
    {
        _canvas.SetActive(true);
      //  EnableCanvasEvent?.Invoke(this, _textMesh);
        EnableObjectsColliders(true);
    }

    public override void OnHoverIn(InteractHand interactHand)
    {
        base.OnHoverIn(interactHand);
        //_canIterractSign.SetActive(true);
    }
    public override void OnHoverOut(InteractHand interactHand)
    {
        base.OnHoverOut(interactHand);
        //_canIterractSign.SetActive(false);

    }
    public Transform GetDietPosition()
    {
        return _dietPosition;
    }
    public Transform GetAmperPosition()
    {
        return _amperPosition;
    }
    public void DisaleActionButtons()
    {
   

    }
    public void EnableObjectsColliders(bool value)
    {
        if (_objectsWithButtons != null)
            foreach (var item in _objectsWithButtons)
            {
                item.GetComponent<Collider>().enabled = value;
            }
    }

    public void EnableMeasure(bool value)
    {
        _canMeaseure = value;
    }
    public bool GetMeasureValue()
    {
        return _canMeaseure;
    }


}