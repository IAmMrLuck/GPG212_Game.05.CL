using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimation : MonoBehaviour
{

    private Vector2 _movementVector;
    public Animator _animator;

    private void Start()
    {
        _animator.SetFloat("Horizontal", _movementVector.x);
        _animator.SetFloat("Vertical", _movementVector.y);
        _animator.SetFloat("Speed", _movementVector.sqrMagnitude);
    }

    // Update is called once per frame
    void Update()
    {
        _animator.SetFloat("Horizontal", _movementVector.x);
        _animator.SetFloat("Vertical", _movementVector.y);
        _animator.SetFloat("Speed", _movementVector.sqrMagnitude);

    }
}
