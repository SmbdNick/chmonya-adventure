using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

    public GameObject Chmonya;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Chmonya")
        {
            SetParent(Chmonya);
            transform.localPosition = new Vector3(-0.73f, -0.6f, 0);
        }


    }

    public void SetParent(GameObject newParent)
    {
        //Makes the GameObject "newParent" the parent of the GameObject "player".
        gameObject.transform.parent = newParent.transform;
    }
}
