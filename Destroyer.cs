using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Explosion exp;
    /*exp = ducklingPrefab.GetComponent<Explosion>();
    exp.Explode();*/
    void OnCollisionEnter2D(Collision2D col)
    {
        GameObject g = col.gameObject;
        Destroy(col.gameObject);
        exp = gameObject.GetComponent<Explosion>();
        exp.Explode(g);
    }
}
