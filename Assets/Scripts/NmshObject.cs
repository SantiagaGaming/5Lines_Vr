using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NmshObject : MovebleObject
{
    [SerializeField] private GameObject _bolt;
    public override void RepairObject()
    {
        StartCoroutine(RapirNmsh());
    }
    private IEnumerator RapirNmsh()
    {
        _moveObjButton.SetActive(false);
        int xRot = 0;
        while (xRot <= 90)
        {
            _bolt.transform.localRotation = Quaternion.Euler(-xRot, 0, 0);
            xRot++;
            yield return new WaitForSeconds(0.01f);
        }
        int x = 0;

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

        while (x > 0)
            {
                if (!_yPoz)
                    transform.position -= new Vector3(0.012f, 0, 0);
                else
                    transform.position -= new Vector3(0, 0.012f, 0);
                yield return new WaitForSeconds(0.02f);
                x--;
            }
        while (xRot >= 0)
        {
            _bolt.transform.localRotation = Quaternion.Euler(-xRot, 0, 0);
            xRot--;
            yield return new WaitForSeconds(0.01f);
        }
        _moveObjButton.SetActive(true);
        
    }
}
