using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    [SerializeField] private Button startGame;
    public TMP_InputField playersName;


    private void Awake()
    {
        playersName = GetComponent<TMP_InputField>();

        playersName.onValueChanged.AddListener(EnableButton);
    }


    private void OnEnable()
    {
        EnableButton(playersName.text);
    }


    private void EnableButton(string input)
    {
        startGame.interactable = !string.IsNullOrWhiteSpace(input);
    }


    public void LoadGame()
    {
        SceneManager.LoadScene("MainGame");
        // ConversationScript.whateverTheStringofrPlayerNameIs = playersName.text;
        // this will need to come in a little later, once we have worked on the idalogue a little more
    }
}
