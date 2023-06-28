using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float xValue = 0f;
    //public float yValue = 0f;
    [SerializeField] float yValue = 0f;
    public float zValue = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update() //every single frame
    {
        transform.Translate(xValue, yValue, zValue); 
    }
}
