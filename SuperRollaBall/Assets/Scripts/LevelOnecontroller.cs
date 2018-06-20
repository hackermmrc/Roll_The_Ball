using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOnecontroller : MonoBehaviour {

    public GameObject lc;
    //public bool texton = true;
    //public float timer = 0; 
	// Use this for initialization
	void Start () {
        GameObject tempStartTxt = (GameObject)Instantiate(lc);
        Destroy(tempStartTxt, 1.5f);

    }

    // Update is called once per frame
    void Update () {
        Destroy(gameObject, 0.3f);
        /*
        timer += Time.deltaTime;

        if (texton == true)
        {
            Instantiate(lc, transform.position, Quaternion.identity);
        }
        if(timer > 0.2)
        {
            texton = false;
            
        }
        Destroy(lc, 1.5f);
        
       // if (timer >= )
       */

    }
}
