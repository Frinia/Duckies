using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DucklingFollow : MonoBehaviour
{
    public Transform leader;
    public float followSharpness = 1.1f;

    Vector3 _followOffset;
    
     private float fSpeed;

    void Start()
    {
        

        _followOffset = transform.position - leader.position;
    }


    void LateUpdate()
    {
        
        Vector3 targetPosition = leader.position + _followOffset;
        //targetPosition.y = transform.position.y;
        transform.position += (targetPosition - transform.position) * followSharpness;
    }
}
