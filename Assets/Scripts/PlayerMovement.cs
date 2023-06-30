using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private GameObject playerCharacter;
    [SerializeField] private Rigidbody2D playerCharacterRB;
    [SerializeField] private float movementSpeed;
    private Vector2 _movementVector;

    

    void Start()
    {
        playerCharacterRB.GetComponent<Rigidbody2D>();

    }


    void Update()
    {
        _movementVector.x = Input.GetAxisRaw("Horizontal");
        _movementVector.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        playerCharacterRB.MovePosition(playerCharacterRB.position + _movementVector * movementSpeed * Time.fixedDeltaTime);
    }
}
