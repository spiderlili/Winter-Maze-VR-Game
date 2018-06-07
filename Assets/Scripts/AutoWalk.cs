using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoWalk : MonoBehaviour {
    public float speed = 1.0f; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
		
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Snowman")) {
            SceneManager.LoadScene("EndScene");
        }
    }
}
