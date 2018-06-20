using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public Vector3 offset;
    public float moveSpeed = 1000f;
    Rigidbody rb;

    public Vector3 resetPosition;
    canvasController cc;
    public CollectiblesScript cs;

    public GameObject checkpointCanvas;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        offset = (Camera.main.transform.position - transform.position);
        cc = GameObject.Find("Canvas").GetComponent<canvasController>();
        resetPosition = (transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.transform.position = transform.position + offset;
        float hdir = Input.GetAxisRaw("Horizontal");
        float vdir = Input.GetAxisRaw("Vertical");

        Vector3 directionVector = new Vector3(hdir, 0, vdir);
        Vector3 unitVector = directionVector.normalized;
        Vector3 forceVector = unitVector * moveSpeed * Time.deltaTime;

        

        rb.AddForce(forceVector);

        if (rb.transform.position.y <= -10)
        {
            transform.position = resetPosition;
        }

       
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "checkpoint")
           
        //Destroy(checkpointCanvas, 1.5f);
        {
            Instantiate(checkpointCanvas, transform.position, Quaternion.identity);
            if (resetPosition != other.transform.position)
            {
                resetPosition = other.transform.position;

            }
        }

     


        if (other.gameObject.tag == "Collectible")
        {
            cc.IncreaseScore(50);
             //isCollected = true;
            


        }
        
    
   
       

        
    }

    void ReturnToCheckpoint()
    {
        transform.position = resetPosition;
    }
}
