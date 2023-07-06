using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace CDF05
{

    /// <summary>
    /// Based on Brackeys Dialogue Tutorial
    /// If you want to have a play around with the dialogue function
    /// Check out the StartConvo Button 
    /// You can edit, remove or increase the number of sentences
    /// As well as change the name of the person you're talking to
    /// </summary>
    

    public class DialogueManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text nameText;
        [SerializeField] private TMP_Text dialogueText;
        [SerializeField] private Animator dialogueOpen;

        [SerializeField] private float letterDelay;

        private Queue<string> _sentences;

        private bool _isDialogueEnd;
        public ButtonChoiceManager currentButtonChoiceManager;

        void Start()
        {
            _sentences = new();
            //_buttonChoiceManager = FindObjectOfType<ButtonChoiceManager>();
        }

        public void StartDialogue(Dialogue dialogue)
        {
            dialogueOpen.SetBool("isOpen", true);

            // this will be the function which is called by the trigger 
            // this starts the queue of sentences and attches a name to the dialogue box

            nameText.text = dialogue.name;

            _sentences.Clear();
            // used to the clear the queue of any elements - I guess this is to ensure there's nothing left over in the queue before calling our next method?

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
                if (!_isDialogueEnd)
                {
                    _isDialogueEnd = true;
                    EndDialogue();
                }
                return;
            }

            string sentence = _sentences.Dequeue();
            dialogueText.text = sentence;
            StopAllCoroutines(); 
            StartCoroutine(TypeSentence(sentence));
            // we need to run StopAllCoroutines() rather than just StopCoroutine because it gives a really weird glitch. Might be funt to work with somehow
        }

        IEnumerator TypeSentence(string sentence)
        {
            dialogueText.text = "";
            
            foreach (char letter in sentence.ToCharArray())
            {
                dialogueText.text += letter;
                yield return new WaitForSeconds(0.01f);
            }
        }

        public void EndDialogue()
        {
            // prevents the sentences from simply looping again
            // or throwing any errors - no in game functionality yet
            dialogueOpen.SetBool("isOpen", false);

            // needs to call a button choice to either accept or decline
            currentButtonChoiceManager.RunShowQuestion();
            //buttonChoiceManager.RunShowQuestion();

            Debug.Log("End of conversation");
        }

    }
}