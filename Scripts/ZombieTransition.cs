using UnityEngine;
using System.Collections;

public class ZombieTransition : MonoBehaviour {
    public float speed = 10f;
    public Vector3 maxVelocity = new Vector3(3, 5);
    public GameObject Zombie;
    public Animator zombieAnim;
    public GameObject Player;
    float damage = .1f;

    void Awake()
    {
        zombieAnim = Zombie.GetComponent<Animator>();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerStay(Collider other)
    {
        //GetComponent<Animation>().Play();
        print("Attack");
        other.gameObject.GetComponent<CharacterHealth>().TakeDamage(damage);
    }
}
