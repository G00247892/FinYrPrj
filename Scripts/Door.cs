using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
    public enum State
    {
        open,
        close,
        inbetween
    }
    public State state;
	
    
    
    // Use this for initialization
	void Start () {
        state = Door.State.close;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnMouseEnter()
    {
        Debug.Log("Enter");
    }
    public void OnMouseExit()
    {
        Debug.Log("Exit");
    }
    public void OnMouseUp()
    {
        Debug.Log("Up");

    }
    private void Open()
    {
       
    }
    private void Close()
    {

    }
}
