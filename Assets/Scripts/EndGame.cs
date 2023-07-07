using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class EndGame : MonoBehaviour
{


        [SerializeField] private TextMeshProUGUI textMeshProUGUI;
        [SerializeField] private Button yesButton;
        [SerializeField] private Button noButton;
        private KeyCode yesKey = KeyCode.Y;
        private KeyCode noKey = KeyCode.N;

        public Animator _animator;

    private void Update()
    {
        // this is a LAMBDA 
        // I don't know what that means

        ShowQuestion("Don't you think things are easier with help?",
            () =>
            {
                Debug.Log("Yes");
            },
            () =>
            {
                Debug.Log("No");
            });

    }

        public void ShowQuestion(string questionText, Action yesAction, Action noAction)
        {
            textMeshProUGUI.text = questionText;
            yesButton.onClick.AddListener(new UnityEngine.Events.UnityAction(yesAction));
            noButton.onClick.AddListener(new UnityEngine.Events.UnityAction(noAction));
        }

        public void CloseChoices()
        {
            _animator.SetBool("isOpen", false);

        }

    }

