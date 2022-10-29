using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScreen : MonoBehaviour
{
    public Camera camera;
    public float cameraIndex = 0f;


    List<Vector3> vectors = new List<Vector3>
    {
        new Vector3 (0.13f, -0.17f, -10f),
        new Vector3 (20.01f, -0.17f, -10f),
        new Vector3 (-21.41f, -0.17f, -10f),
        new Vector3 (5.62f, -13.18f, -10f),
        new Vector3 (25.82f, -13.18f, -10f),
        new Vector3 (46.06f, -13.18f, -10f),
        new Vector3 (66.38f, -13.18f, -10f),
    };
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //cameraIndex = (float)cameraPosition.firstLocationfirstCam;
        if (collision.tag == "Chmonya")
        {
            camera.transform.localPosition = vectors[(int)cameraIndex];
        }
    }
}

//public enum cameraPosition
//{
//    firstLocationfirstCam = 0,
//}