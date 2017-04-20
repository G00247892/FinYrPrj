using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {
    public GameObject guiObject;
    public string levelToLoad;
	// Use this for initialization
	void Start () {
        guiObject.SetActive(false);
	}

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            guiObject.SetActive(true);
            if(guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))//If triggered guiObject is true
            {
                Application.LoadLevel(levelToLoad);
            }
           // SceneManager.LoadScene("TestScene");
        }
    }

    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
