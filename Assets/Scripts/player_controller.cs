using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    /* movimiento */
    public float Speed;
    private float horizontal;


    /* Parametros */
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    private void Awake() {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /* movimiento */
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate() {
        _rigidbody.velocity = new Vector2(horizontal * Speed, _rigidbody.velocity.y);
    }

    private void LateUpdate() {
        _animator.SetInteger("Idle", Mathf.Abs(((int)horizontal)));
    }
}
