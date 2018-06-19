using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public Vector3 offset;
    public float moveSpeed = 1000f;
    Rigidbody rb;

    canvasController cc;
    public CollectiblesScript cs;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        offset = (Camera.main.transform.position - transform.position);
        cc = GameObject.Find("Canvas").GetComponent<canvasController>();
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

       
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectible")
        {
            cc.IncreaseScore(50);
             //isCollected = true;
            ;


        }
    }
}
