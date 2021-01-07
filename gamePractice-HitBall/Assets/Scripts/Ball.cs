using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(-10.0f, 9.0f, 0.0f);
    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
