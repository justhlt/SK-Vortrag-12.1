using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript lolgic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        lolgic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y >= 25 || transform.position.y <= -25)
        {
            lolgic.gameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        lolgic.gameOver();
    birdIsAlive = false;
    }

}
