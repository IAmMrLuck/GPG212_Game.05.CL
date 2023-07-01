using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CDF05
{
    /// <summary>
    /// This selects the button on screen which is added into the serialized field
    /// The button will need to eventually be a Prefabn
    /// </summary>
    


    public class KeyBindButton : MonoBehaviour
    {
        [SerializeField] private KeyCode activationKey; // choose the KeyCode in the inspector
        [SerializeField] private Button selectedButton;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(activationKey))  // currently set to "E"
            {
                if (selectedButton != null)
                {
                    // Trigger the selected button's click event
                    selectedButton.onClick.Invoke();
                }
            }
        }
    }
}