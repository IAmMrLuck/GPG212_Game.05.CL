using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CDF05
{
    public class ButtonChoice : MonoBehaviour
    {
        [SerializeField] private Button buttonComponent;
        [SerializeField] private Text buttonText;
        [SerializeField] private Color normalColor;
        [SerializeField] private Color selectedColor;

        private bool _isSelected;

        private void Awake()
        {
            buttonComponent.onClick.AddListener(HandleButtonClick);
        }

        public void SetupButton(string text)
        {
            buttonText.text = text;
        }

        public void SetSelected(bool isSelected)
        {
            _isSelected = isSelected;

            if (_isSelected)
            {
                buttonText.color = selectedColor;
            }
            else
            {
                buttonText.color = normalColor;
            }
        }

        private void HandleButtonClick()
        {
            Debug.Log("Button clicked: " + buttonText.text);

            // Handle the button click here based on buttonText.text
            // You can add different actions or callbacks for each button option
        }
    }
}

