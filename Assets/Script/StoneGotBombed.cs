using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGotBombed : MonoBehaviour {

    public GameObject bomb;
    public GameObject bombExplosion;
    public GameObject explosion;
    public GameObject cave;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bomb")
        {
            Destroy(bomb);
            Instantiate(bombExplosion, new Vector3(6.059f, -0.242f, 0), Quaternion.identity);
            StartCoroutine(Explosion());
        }


    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(4);
        GameObject bombExplosionClone = GameObject.Find("Bomb (1)(Clone)");
        Destroy(bombExplosionClone);
        Instantiate(explosion, new Vector3(6.2f, 0.95f, 0), Quaternion.identity);
        yield return new WaitForSeconds(2);
        GameObject explosionClone = GameObject.Find("Explosion(Clone)");
        Destroy(explosionClone);
        Destroy(gameObject);

        cave.GetComponent<BoxCollider2D>().enabled = true;
    }

}
