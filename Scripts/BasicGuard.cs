//Script that follows the player around. No line of sight implemented and there's a line to show who the object is following for debugging purposes
using UnityEngine;
using System.Collections;

public class BasicGuard : MonoBehaviour {

    Transform target;
    private int maxRange;
    private int minRange;
    private int maxDistance;
    private int moveSpeed = 5;
    private int rotationSpeed = 5;
    private Transform myTransform;

    void Awake()
    {
        myTransform = transform;
    }
    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");

        target = go.transform;

        maxDistance = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(target.position, myTransform.position, Color.yellow);

        //Look at target
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

        if (Vector3.Distance(target.position, myTransform.position) > maxDistance)        {
            //Move towards target
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
        if ((Vector3.Distance(transform.position, target.position) < maxRange)
           && (Vector3.Distance(transform.position, target.position) > minRange))        {
            transform.LookAt(target);
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}
