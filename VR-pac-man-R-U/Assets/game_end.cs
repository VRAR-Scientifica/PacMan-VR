using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_end : MonoBehaviour {
    public Transform vrCamera;
    public float toggleAngle = 45.0f;
    // Use this for initialization

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 180.0f)
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
