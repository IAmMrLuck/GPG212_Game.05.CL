using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CDF05
{

    // Attach this to the NPC you want to talk to
    // this calls the Variables stored in the Dialogue Class
    // I am working on a way to have this begin when the player entrs into a trigger


    public class DialogueTrigger : MonoBehaviour
    {
        public Dialogue dialogue;

        public void TriggerDialogue()
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
    }
}