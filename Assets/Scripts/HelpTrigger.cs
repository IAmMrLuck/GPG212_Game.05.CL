using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

namespace CDF05
{
    /// <summary>
    /// THIS CODE IS NOT FINISHED
    /// I've tried calling the coroutine from Update, but it just runs every frame causing a flicker
    /// calling it whilst in the trigger will work, but it won't stop the function when the player leaves
    /// setting an if() doesn't assist in Update - the same flickering happens
    /// </summary>


    public class HelpTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject helpMessage;
        // private Coroutine _helpCoroutine;
        private bool _isPlayerCloseEnough;

        private void Start()
        {
            helpMessage.SetActive(false);
            _isPlayerCloseEnough = false;
        }

        private void Update()
        {
            if (_isPlayerCloseEnough)
            {
                StartCoroutine(ShowHelpMessage());
            }
            else return;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("Trigger entered");
            _isPlayerCloseEnough = true;
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            Debug.Log("Left Trigger");
            _isPlayerCloseEnough = false;
        }



        private IEnumerator ShowHelpMessage()
        {
            while (_isPlayerCloseEnough)
            {
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