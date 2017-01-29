using UnityEngine;
using System.Collections;
[RequireComponent (typeof (NavMeshAgent))]
public class Guard : MonoBehaviour {

    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed = 5;
    public float damping;
    public Transform fpsTarget;
    Rigidbody theRigidBody;
    Renderer myRender;

    void start(){
        myRender = GetComponent<Renderer>();
        theRigidBody = GetComponent<Rigidbody>();
    }

    

	// Update is called once per frame
	void FixedUpdate () {


	}

}
