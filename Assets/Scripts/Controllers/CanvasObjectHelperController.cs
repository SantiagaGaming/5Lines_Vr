using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasObjectHelperController : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI _textMesh;
    [SerializeField] private GameObject _canvasObject;

    public void ShowTextHelper(string name, Transform newPos)
    {
        _canvasObject.SetActive(true);
        _textMesh.text = name;
        transform.position = newPos.position;
    }
    public void HidetextHelper()
    {
        _canvasObject.SetActive(false);
    }


}
