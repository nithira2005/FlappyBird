using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenghth;
    public LogicScript logic;
    public bool birdAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& birdAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrenghth;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }

}
