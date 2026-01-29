using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    float speed = 2;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.W)){
            speed = 2;
        }

        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.up * Time.deltaTime * speed;
            speed *= 1.005f;
        }

        if (Input.GetKeyUp(KeyCode.S)){
            speed = 2;
        }

        if (Input.GetKey(KeyCode.S)) {
            transform.position += Vector3.down * Time.deltaTime * speed;
            speed *= 1.005f;
        }
    }
}
