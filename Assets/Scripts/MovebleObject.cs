using System.Collections;
using AosSdk.Core.Interaction.Interfaces;
using AosSdk.Core.Utils;
using UnityEngine;
using UnityEngine.Events;


public class MovebleObject : MonoBehaviour
{
    [SerializeField] protected GameObject _moveObjButton;
    [SerializeField][HideInInspector] protected bool _condition;
    [SerializeField] protected bool _yPoz;

    protected CanvasController canvasController;
   protected void Start()
    {
        canvasController = FindObjectOfType<CanvasController>();
    }
    public virtual void RepairObject()
    {
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    { int x = 0;
        EnableObjectsInCanvas(false);
        _condition = true;
        while (x<=32)
        {
            if(!_yPoz)
           transform.position += new Vector3(0.012f, 0, 0);
            else
                transform.position += new Vector3(0, 0.012f, 0);
            yield return new WaitForSeconds(0.02f);
            x++;
        }
        if (GetComponent<MeshRenderer>())
        {
            GetComponent<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            GetComponent<MeshRenderer>().enabled = true;
        }
        else 
        {
        GetComponentInChildren<MeshRenderer>().enabled = false;
            yield return new WaitForSeconds(0.5f);
            GetComponentInChildren<MeshRenderer>().enabled = true;
        }

        while (x>0)
        {
            if (!_yPoz)
                transform.position -= new Vector3(0.012f, 0, 0);
            else
                transform.position -= new Vector3(0, 0.012f, 0);
            yield return new WaitForSeconds(0.02f);
            x--;
        }
        EnableObjectsInCanvas(true);
    }
   protected void EnableObjectsInCanvas(bool value)
    {
        canvasController.EnableCanvasObjectsColliders(value);
        canvasController.EnbaleMeasureActions(value);
        _moveObjButton.SetActive(value);
    }
    public bool GetCondition()
    {
        return _condition;
    }
    public void SetCondition(bool value)
    {
        _condition = value;
    }
}
