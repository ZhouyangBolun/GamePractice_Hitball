using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject ballPrefabs;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(this.ballPrefabs);
        }
    }
}
