﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiblesScript : MonoBehaviour {

    public float bananaupSpeed;
    public Vector3 textPosition = new Vector3(0, 1, 0);
    public bool isCollected = false;
    public GameObject GameText;
    AudioSource audioSource;
    bool played;
	// Use this for initialization
	void Start () {
        played = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (isCollected)
        {
            played = true;
            if (played == true)
            {
                
            }
            Debug.Log("isCollected has been set True for me!");
            Destroy(this.gameObject, 1f);
            Disappear();
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.Play();
            isCollected = true;
            Instantiate(GameText, transform.position + textPosition, Quaternion.identity);
        }
    }

    void Disappear()
    {
        this.transform.Rotate(Vector3.up, 720 * Time.deltaTime);
        transform.Translate(Vector3.up * Time.deltaTime * bananaupSpeed, Space.World);
        this.transform.localScale += new Vector3(.25f, .25f, .25f) * Time.deltaTime;
    }
}
