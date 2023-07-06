using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace CDF05
{
    public class ButtonChoiceManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI textMeshProUGUI;
        [SerializeField] private Button yesButton;
        [SerializeField] private Button noButton;
        private KeyCode yesKey = KeyCode.Y;
        private KeyCode noKey = KeyCode.N;

        public Animator _animator;

        void Update()
        {
            if (Input.GetKeyDown(yesKey))  // currently set to "E"
            {
                if (yesButton != null)
                {
                    // Trigger the selected button's click event
                    yesButton.onClick.Invoke();
                }
            }

            if (Input.GetKeyDown(noKey))  // currently set to "E"
            {
                if (noButton != null)
                {
                    // Trigger the selected button's click event
                    noButton.onClick.Invoke();
                }
            }
        }

        public void RunShowQuestion()
        {
            _animator.SetBool("isOpen", true);
            // this is a LAMBDA 
            // I don't know what that means

            ShowQuestion("Do you trust me..?",
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
}
