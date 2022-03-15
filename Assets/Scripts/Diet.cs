using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diet : MonoBehaviour
{
    [SerializeField] private GameObject _diet;
    [SerializeField] private GameObject _buttons;
    [SerializeField] private SoundPlayer _soundPlayer;

    public void EnableDiet(bool value, Transform position)
    {
        _diet.transform.position = position.position;
        _diet.transform.rotation = position.rotation;
        StartCoroutine(DietMover(value));
    }
    private IEnumerator DietMover(bool value)
    {
        if(value)
        _soundPlayer.PlayRadioSound();
        int x = 0;
        while (x <= 32)
        {
         
            if (value)
            {
                _diet.SetActive(true);
                _diet.transform.position += new Vector3(0, 0.0125f, 0);
            }
       
            else
            {
                _buttons.SetActive(false);
                transform.position -= new Vector3(0, 0.0125f, 0);
            }

            yield return new WaitForSeconds(0.01f);
            x++;
        }
        if(!value)
        {
            _diet.SetActive(false);
        }
        else
            _buttons.SetActive(true);
    }
}
