using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine; 

public class ButtonPrompt : MonoBehaviour
{

    [SerializeField] private GameObject convoStarter;

    private void Awake()
    {
        convoStarter.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        convoStarter.SetActive(true);
    }

}
