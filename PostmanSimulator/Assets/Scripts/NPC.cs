using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWithNPC : MonoBehaviour
{
    private GameObject triggeringNpc;
    private bool triggering;
    public GameObject npcText;

    private void Update()


    {
        if (triggering)
        {
            npcText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Here your Quest");
            }


            else
                npcText.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = true;
            triggeringNpc = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "NPC")
        {
            triggering = false;
            triggeringNpc = null;
        }
    }
}
