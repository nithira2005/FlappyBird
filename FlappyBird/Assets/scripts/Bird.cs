using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    void Start()
    {
        
    }

  
    void Update()
    {
        myRigidbody.velocity = Vector2.up * 10;
    }
}
