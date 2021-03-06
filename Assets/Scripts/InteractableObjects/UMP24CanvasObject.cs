using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class UMP24CanvasObject : CanvasObject
{
    [SerializeField] private GameObject _roof;

    private InteractHand interactHand;

    private bool _isAmimated = false;
    public override void DisableCanvas()
    {
        OnCloseUMPRoof();
        base.DisableCanvas();
    }
    public override void OnClicked(InteractHand interactHand)
    {
        base.OnClicked(interactHand);
        StartCoroutine(RoofMover(true));
    }
    private void OnCloseUMPRoof()
    {
        if(canvasController.CompareObjects(this))
        StartCoroutine(RoofMover(false));
    }

    private IEnumerator RoofMover(bool value)
    {
        if(!_isAmimated && canvasController.CanSwitch)
        {
            _roof.SetActive(true);
            canvasController.CanSwitch = false;
            _isAmimated = true;
            int y = 0;
            while (y < 25)
            {
                if (value)
                    _roof.transform.position += new Vector3(0, 0.01f, 0);
                else
                    _roof.transform.position -= new Vector3(0, 0.01f, 0);
                yield return new WaitForSeconds(0.02f);
                y++;
            }
            canvasController.CanSwitch = true;
            if (value)
            {
                base.OnClicked(interactHand);
                _roof.SetActive(false);
            }
            _isAmimated = false;
        }
    }
}

