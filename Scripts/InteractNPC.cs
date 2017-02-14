using UnityEngine;
using System.Collections;

public class InteractNPC : MonoBehaviour
{
    //This script handles player movement and interaction with other NPC game objects

    //Reference to our diagUI script for quick access
    public exampleUI diagUI;

    void Update()
    {
        //Interact with NPCs when hitting F key
        if (Input.GetKeyDown(KeyCode.F))
        {
            TryInteract();
        }
    }

    //Casts a ray to see if we hit an NPC and, if so, we interact
    void TryInteract()
    {
        RaycastHit rHit;
        if (Physics.Raycast(transform.position, transform.forward, out rHit, 2))
        {
            //In this example, we will try to interact with any collider the raycast finds

            //Lets grab the NPC's DialogueAssign script... if there's any
            VIDE_Assign assigned;
            if (rHit.collider.GetComponent<VIDE_Assign>() != null)
                assigned = rHit.collider.GetComponent<VIDE_Assign>();
            else return;

            if (!diagUI.dialogue.isLoaded)
            {
                //... and use it to begin the conversation
                diagUI.Begin(assigned);
            }
            else
            {
                //If conversation already began, let's just progress through it
                diagUI.NextNode();
            }
        }
    }
}
