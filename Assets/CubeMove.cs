using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float Speed, Distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.right * Speed / 1000);
        if (transform.localPosition.x > Distance) {
            Destroy(gameObject);
        }
    }
}
