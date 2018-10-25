using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawn : MonoBehaviour
{


    public static GameObject pellet1;
    public static GameObject pellet2;
    public static GameObject pellet3;
    public static GameObject pellet4;
    public static GameObject pellet5;
    public GameObject[] a = new GameObject[]{pellet1, pellet2, pellet3, pellet4, pellet5 };
    
    //float x = Random.Range(-9.0f, 9.0f);
    //float z = Random.Range(-9.0f, 9.0f); 
    // Use this for initialization
    void Start () {
        transform.position = a[(int)(Random.Range(0,4))].transform.position;
            //transform.position = new Vector3(x, 1.04f, z);
        
       
    }
	
	// Update is called once per frame
	void Update () {

        
       
	}
}
