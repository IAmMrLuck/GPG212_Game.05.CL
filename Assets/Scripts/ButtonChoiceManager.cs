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

        private void OnTriggerEnter2D(Collider2D collision)
        {
         
            // this is a LAMBDA 
            // I don't know what that means

            ShowQuestion("Do you trust me..?",
                () =>
                {
                    Debug.Log("yes");
                },
                () =>
                {
                    Debug.Log("no");
                });
        }

        public void ShowQuestion(string questionText, Action yesAction, Action noAction)
        {
            textMeshProUGUI.text = questionText;
            yesButton.onClick.AddListener(new UnityEngine.Events.UnityAction(yesAction));
            noButton.onClick.AddListener(new UnityEngine.Events.UnityAction(noAction));
        }

    }
}
