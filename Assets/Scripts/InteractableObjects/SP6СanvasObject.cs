using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using AosSdk.Core.Player;
using AosSdk.Core.Player.Pointer;
using UnityEngine;
using UnityEngine.Events;

public class SP6ÑanvasObject : CanvasObject
{
    [SerializeField] private Animator _anim;
    [SerializeField] private GameObject _roof;

    private InteractHand interactHand;

    private bool _isAmimated = false;
    public override void DisableCanvas()
    {
        OnCloseSp6();
        base.DisableCanvas();
    }

    public override void OnClicked(InteractHand interactHand)
    {
        StartCoroutine(PlaySp6Anim(true));
    }
    private void OnCloseSp6()
    {
        if (canvasController.CompareObjects(this))
        StartCoroutine(PlaySp6Anim(false));
    }

    private IEnumerator PlaySp6Anim(bool value)
    {
        if(!_isAmimated && canvasController.CanSwitch)
        {
            canvasController.CanSwitch = false;
            _isAmimated = true;
            _anim.SetTrigger("kurbelOut");
            yield return new WaitForSeconds(GetAnimLenght());
            StartCoroutine(RoofRotator(value));
            _anim.SetTrigger("kurbelIn");
            yield return new WaitForSeconds(GetAnimLenght());
            canvasController.CanSwitch = true;
            if (value)
            {
                base.OnClicked(interactHand);
            }
            _isAmimated = false;
            yield return new WaitForSeconds(2f);
        }
    }
    private IEnumerator RoofRotator(bool value)
    {
        if (value)
        {
            int z = 0;
            while (z <= 120)
            {
                _roof.transform.localRotation = Quaternion.Euler(0, 0, z);
                z++;
                yield return new WaitForSeconds(0.001f);
            }
        }
        else
        {
            int z = 120;
            while (z >= 0)
            {
                _roof.transform.localRotation = Quaternion.Euler(0, 0, z);
                z--;
                yield return new WaitForSeconds(0.001f);
            }
        }
    }
    private float GetAnimLenght()
    {
        AnimatorStateInfo info = _anim.GetCurrentAnimatorStateInfo(0);
      float animLenght = info.length;
        return animLenght;
    }
}
