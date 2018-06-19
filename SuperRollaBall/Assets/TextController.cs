using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

    public float textRise;

   //
   // public Vector3 offset;
   // public GameObject banana;

	// Use this for initialization
	void Start () {
        //offset = (banana.transform.position - transform.position);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * textRise, Space.World);
        Destroy(gameObject, 1f); 	
	}
}
