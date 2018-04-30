using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiguan1 : MonoBehaviour {
    public GameObject movingBlock1;
    public GameObject button1;
    public bool isTriggered = false;
    // Vector3 oldPos;

    //public Object P2;
   // public Vector2 aPosition1 = new Vector2(-12, -3);
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "button1")
        {
            isTriggered = true;
                Debug.Log("ON_TRIGGER_ENTER CALLED");
                
        }
    }
    public float walkSpeed = 1.0f;      // Walkspeed
    float walkingDirection = 1.0f;
    Vector2 walkAmount;
    float originalY; // Original float value
    public float wallUp = -1f;       // Define wallLeft
    public float wallDown = -6f;      // Define wallRight


    // Use this for initialization
    void Start ()
    {
        originalY= movingBlock1.transform.position.y;
    }


    // Update is called once per frame
    void Update () {
        if (isTriggered)
        {
            button1.SetActive(false);
            walkAmount.y = walkingDirection * walkSpeed * Time.deltaTime;
            if (walkingDirection > 0.0f && movingBlock1.transform.position.y >= wallDown)
            {
                walkingDirection = -1.0f;
            }
            else if (walkingDirection < 0.0f && movingBlock1.transform.position.y <= wallUp)
            {
                walkingDirection = 1.0f;
            }
            movingBlock1.transform.Translate(walkAmount);
        }


    }





}
