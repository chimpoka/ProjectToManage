using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour {

    public float speed = 2.0f;
    //public Transform thisTransform;


    //private void Awake()
    //{
    //    thisTransform = GetComponent<Transform>();
    //}
    // Update is called once per frame
    void Update ()
    {
        transform.position += new Vector3(Input.acceleration.x * speed * Time.deltaTime,
                                          0,
                                          -Input.acceleration.z * speed * Time.deltaTime);

        Debug.Log(Input.acceleration);
	}
}
