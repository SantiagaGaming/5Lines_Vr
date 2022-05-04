using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class FartukCanvasObject : CanvasObject
{
    [SerializeField] private GameObject _roof;
    public override void OnClicked(InteractHand interactHand)
    {
        StartCoroutine(RoofRotator(true));
        base.OnClicked(interactHand);
    }
    private void OnCloseFartuk()
    {
        if (canvasController.CompareObjects(this))
            StartCoroutine(RoofRotator(false));
    }
    public override void DisableCanvas()
    {
        OnCloseFartuk();
        base.DisableCanvas();
    }

    private IEnumerator RoofRotator(bool value)
    {
        if (value)
        {
            int x = 0;
            while (x <= 90)
            {
                _roof.transform.localRotation = Quaternion.Euler(x, 0,0 );
                x++;
                yield return new WaitForSeconds(0.001f);
            }
        }
        else
        {
            int x = 90;
            while (x >= 0)
            {
                _roof.transform.localRotation = Quaternion.Euler(x, 0, 0);
                x--;
                yield return new WaitForSeconds(0.001f);
            }
        }
        canvasController.CanSwitch = true;
    }
}
