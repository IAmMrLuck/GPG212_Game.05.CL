using System.Collections;
using System.Collections.Generic;
using System.Net;
using TMPro;
using UnityEngine;

namespace CDF05
{
    /// <summary>
    /// this functions now
    /// The playercharacter enters the trigger, and it turns on the message
    /// then it waits for time and when the player leaves the tirgger, It doesn't stop instantly
    /// It doesn't flicker - It's functioning well
    /// </summary>


    public class HelpTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject playerTag;
        [SerializeField] private GameObject helpMessage; //change to text object in inspector
        private bool _isPlayerCloseEnough;


        private void Start()
        {
            helpMessage.SetActive(false); 
            _isPlayerCloseEnough = false;
        }


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (playerTag.CompareTag("Player")) // this playerTag might not be neccessary - but if we add something else it will save us then
            {
                Debug.Log("Trigger entered");
                _isPlayerCloseEnough = true;
                StartCoroutine(ShowHelpMessage());
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (playerTag.CompareTag("Player"))
            {
                Debug.Log("Left Trigger");
                StopCoroutine(ShowHelpMessage());
                _isPlayerCloseEnough = false;
            }
        }

        private IEnumerator ShowHelpMessage()
        {
            while (_isPlayerCloseEnough)
            { // this coroutine is used to set the callout by the NPC's to play be on and off for 3 second intervals
                // it should give the effect of someone calling out in the darkness
                
                helpMessage.SetActive(true);

                yield return new WaitForSeconds(3);
                Debug.Log("Waited 3 Secs first");

                helpMessage.SetActive(false);

                yield return new WaitForSeconds(3);
                Debug.Log("waited 3 secs second");
            }
        }
    }
}