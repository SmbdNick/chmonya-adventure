using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{

    public GameObject Chmonya;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Chmonya")
        {
            SetParent(Chmonya);
            transform.localPosition = new Vector3(1.26f, 0.26f, 0);
            transform.localScale = new Vector3(-0.2f, 0.2f, 1);

            Chmonya.GetComponent<ChmonyaAttack>().enabled = true;
        }


    }

    public void SetParent(GameObject newParent)
    {
        //Makes the GameObject "newParent" the parent of the GameObject "player".
        gameObject.transform.parent = newParent.transform;
    }
}
