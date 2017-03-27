using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
       // Application.LoadLevel("TestScene");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTrigger(Collider other)
    {
        if(other.tag=="Player")
        {
            SceneManager.LoadScene("TestScene");
        }
    }
}
