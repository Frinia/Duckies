using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckmomMovement : MonoBehaviour
{
    private float fTurnRate = 200.0f;
    private float fSpeed = 5.0f;



    

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward * fTurnRate * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(-Vector3.forward * fTurnRate * Time.deltaTime);
        transform.localPosition = transform.localPosition + transform.up * fSpeed *Time.deltaTime;

   

    }
}