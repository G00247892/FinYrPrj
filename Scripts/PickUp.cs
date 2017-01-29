using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {
    GameObject grabbedObject;
    float grabbedObjectSize;

	// Use this for initialization
	void Start () {
	
	}
    GameObject GetMouseHoverObject(float range) {
        Vector3 position = gameObject.transform.position;
        RaycastHit raycastHit;
        Vector3 target = position + Camera.main.transform.forward * range;
        if (Physics.Linecast(position, target,out raycastHit))
            return raycastHit.collider.gameObject;
        return null;
    }
    void TryGrabObject(GameObject grabObject)
    {
        if (grabObject == null)
            return;
        grabbedObject = grabObject;
        //GetComponent.< Renderer > ().bounds.size;


    }
    void DropObject()
    {
        if (grabbedObject == null)
            return;
        grabbedObject = null;
    }

   
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            if (grabbedObject == null)
                TryGrabObject(GetMouseHoverObject(5));
            else
                DropObject();
        }

        if(grabbedObject!=null)
        {
            Vector3 newPosition = gameObject.transform.position + Camera.main.transform.forward * 5;
            grabbedObject.transform.position = newPosition;

        }
	}

}
