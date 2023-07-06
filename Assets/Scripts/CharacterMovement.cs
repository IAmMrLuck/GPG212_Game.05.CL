using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace CDF05
{
    /// <summary>
    /// simple character movement controller
    /// FEEL FREE TO TWEAK OR CHANGE IF NEEDED 
    /// </summary>


    public class CharacterMovement : MonoBehaviour
    {

        [SerializeField] private GameObject playerCharacter;
        [SerializeField] private Rigidbody2D playerCharacterRB;
        [SerializeField] private float movementSpeed;
        private Vector2 _movementVector;
        public Animator _animator;

        void Start()
        {
            playerCharacterRB.GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            _movementVector.x = Input.GetAxisRaw("Horizontal");
            _movementVector.y = Input.GetAxisRaw("Vertical");

            _animator.SetFloat("Horizontal", _movementVector.x);
            _animator.SetFloat("Vertical", _movementVector.y);
            _animator.SetFloat("Speed", _movementVector.sqrMagnitude);

        }

        private void FixedUpdate()
        {
            playerCharacterRB.MovePosition(playerCharacterRB.position + _movementVector * movementSpeed * Time.fixedDeltaTime);
        }
    }
}