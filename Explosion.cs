using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public GameObject pooffab;

    public void Explode(GameObject g)
    {
        GameObject expl = Instantiate(pooffab, g.transform.position, Quaternion.identity);
        Destroy(expl, 1.3f);
    }
}