using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CDF05
{


    public class DialogueManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text dialogueText;

        private Queue<string> _sentences;

        void Start()
        {
            _sentences = new Queue<string>();
        }

        public void StartDialogue(Dialogue dialogue)
        {
            // this will be the function which is called by the trigger 
            // this starts the queue of sentences and attches a name to the dialogue box

            nameText.text = dialogue.name;

            _sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                _sentences.Enqueue(sentence);
            }

            DisplayNextSentence();
        }


        public void DisplayNextSentence()
        {
            // attch this function to the "continue button" to make the next sentce appear

            if (_sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            string sentence = _sentences.Dequeue();
            dialogueText.text = sentence;
        }

        public void EndDialogue()
        {
            // prevents the sentences from simply looping again
            // or throwing any errors - no in game functionality yet

            Debug.Log("End of conversation");
        }

    }
}