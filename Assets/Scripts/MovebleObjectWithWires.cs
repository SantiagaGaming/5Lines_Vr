using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovebleObjectWithWires : MovebleObject
{
    [SerializeField] private GameObject _wiresOn;
    [SerializeField] private GameObject _wiresOff;
    public override void RepairObject()
    {
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    {
        int x = 0;
        EnableObjectsInCanvas(false);
        _wiresOff.SetActive(true);
        _wiresOn.SetActive(false);
        _condition = true;
        while (x <= 32)
        {
            if (!_yPoz)
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

        while (x > 0)
        {
            if (!_yPoz)
                transform.position -= new Vector3(0.012f, 0, 0);
            else
                transform.position -= new Vector3(0, 0.012f, 0);
            yield return new WaitForSeconds(0.02f);
            x--;
        }
        EnableObjectsInCanvas(true);
        _wiresOff.SetActive(false);
        _wiresOn.SetActive(true);
    }

}
