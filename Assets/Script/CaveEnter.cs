using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveEnter : MonoBehaviour
{
    public GameObject caveEntrance;
    public Camera camera;
    private bool entered = false;

    public GameObject Chmonya;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Chmonya")
        {
            caveEntrance.SetActive(true);
            entered = true;
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Chmonya")
        {
            caveEntrance.SetActive(false);
            entered = false;
        }
    }

    private void Update()
    {
        if (entered && Input.GetKeyDown(KeyCode.Space))
        {
            camera.transform.localPosition = new Vector3(5.62f, -13.18f, -10f);
            Chmonya.transform.localPosition = new Vector3(4.62f, -6.65f, 0);
            Chmonya.GetComponent<Rigidbody2D>().gravityScale = 50;
            Invoke("ReturnNormalGravity", 2);
        }
        
    }

    void ReturnNormalGravity()
    {
        Chmonya.GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
