using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;

    void Awake() {

    }

    void Start()
    {
        // rotate 45 degrees around the z axis
        car.transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
