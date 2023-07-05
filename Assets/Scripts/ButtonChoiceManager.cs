using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CDF05
{
    public class ButtonChoiceManager : MonoBehaviour
    {
        [SerializeField] private GameObject buttonChoicesParent;
        [SerializeField] private GameObject buttonPrefab;

        private ButtonChoice _acceptButton;
        private ButtonChoice _declineButton;

        private void Start()
        {
            _acceptButton = CreateButton("Accept");
            _declineButton = CreateButton("Decline");

            // Select the Accept button by default
            _acceptButton.SetSelected(true);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SelectButtonChoice(_declineButton);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                SelectButtonChoice(_acceptButton);
            }
        }

        public void ShowButtonChoices()
        {
            buttonChoicesParent.SetActive(true);
        }

        private ButtonChoice CreateButton(string buttonText)
        {
            GameObject buttonGO = Instantiate(buttonPrefab, buttonChoicesParent.transform);
            ButtonChoice buttonChoice = buttonGO.GetComponent<ButtonChoice>();
            buttonChoice.SetupButton(buttonText);
            return buttonChoice;
        }

        private void SelectButtonChoice(ButtonChoice buttonChoice)
        {
            // Set the selected state for the button choices
            _acceptButton.SetSelected(buttonChoice == _acceptButton);
            _declineButton.SetSelected(buttonChoice == _declineButton);
        }
    }
}
