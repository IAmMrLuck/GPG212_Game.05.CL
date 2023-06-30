using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private GameObject playerCharacter;
    [SerializeField] private Rigidbody2D playerCharacterRB;
    [SerializeField] private float movementSpeed;

    

    void Start()
    {
        playerCharacterRB.GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        
    }
}
