using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 45;
    private float horizontalInput;
    private float forwardInput;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Collectable"))
        {
            
            //Increase the player's score. 
           GameManager.playerScore += 10;
            //Destroy the collectible.  
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //vertical movement//
        transform.Translate(Vector3.up *Time.deltaTime* speed * forwardInput);
        //rotates horizantal//
        transform.Rotate(Vector3.forward, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
