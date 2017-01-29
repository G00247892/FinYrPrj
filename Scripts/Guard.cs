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
        fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
        if (fpsTargetDistance < enemyLookDistance){
           // myRender.material.color = Color.yellow;
            LookAtPlayer();
            print("Look at player please");
        }
        if(fpsTargetDistance < attackDistance)
        {
           // myRender.material.color = Color.red;
            AttackPlease();
            print("ATTACK");
        }
        else
        {
            //myRender.material.color = Color.blue;
        }

	}

    void LookAtPlayer(){
        Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime*damping);
    }

    void AttackPlease()
    {
       // theRigidBody.AddForce(transform.forward*enemyMovementSpeed);
    }
}
