using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class Door : BaseObject
{
    public UnityAction<Transform, string> TeleportToObjectEvent;
    public UnityAction AosTeleportEvent;
    [SerializeField] private Transform _newPlayerPosition;
    [SerializeField] private Transform _helperPos;
    [SerializeField] private string _name;
    private CanvasObjectHelperController _canvasHelper;
    protected override void Start()
    {
        base.Start();
        _canvasHelper = FindObjectOfType<CanvasObjectHelperController>();
    }
    public override void OnHoverIn(InteractHand interactHand)
    {
        base.OnHoverIn(interactHand);
        StartCoroutine("GetHelpName");
    }
    public override void OnHoverOut(InteractHand interactHand)
    {
        base.OnHoverOut(interactHand);
        timer = 2;
        StopCoroutine("GetHelpName");
    }
    public void StartTeleporting()
    {
        TeleportToObjectEvent?.Invoke(_newPlayerPosition, gameObject.name);
        AosTeleportEvent?.Invoke();
    }
   override public void OnClicked(InteractHand interactHand)
    {
        StartTeleporting();
    }


    private IEnumerator GetHelpName()
    {
        yield return new WaitForSeconds(timer);
        _canvasHelper.ShowTextHelper(_name, _helperPos);
    }

}
