using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowEndGame : MonoBehaviour
{

    [SerializeField] private GameObject endGame;
    [SerializeField] private Animator endAnimator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        endAnimator.SetBool("isOpen", true);
   
    }

    public void EndGame()
    {
        Application.Quit();
    }

}
