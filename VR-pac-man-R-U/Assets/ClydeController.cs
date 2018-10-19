using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeController : MonoBehaviour {

    public Transform Clyde;

    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;

    public int num;
    public float step;
    // Use this for initialization
    void Start () {
        step = 3 * Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine("TimeCheck");
        //num = Random.Range(1, 7);

            if (num == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos1.transform.position, step);
            }
            if (num == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos2.transform.position, 0.4f);
            }
            if (num == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos3.transform.position, 0.4f);
            }
            if (num == 4)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos4.transform.position, 0.4f);
            }
            if (num == 5)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos5.transform.position, 0.4f);
            }
            if (num == 6)
            {
                transform.position = Vector3.MoveTowards(transform.position, pos6.transform.position, 0.4f);
            } 
    }

    IEnumerator TimeCheck()
    {
        yield return new WaitForSeconds(3);
        
    }
}
