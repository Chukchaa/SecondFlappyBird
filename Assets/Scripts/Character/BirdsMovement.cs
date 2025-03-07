using FlappyBird.Pause;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsMovement : Pausable
{
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private float _rotationSpeed = 5f;

    private float _maxRotation = 45;
    private float _minRotation = -75;
    private Rigidbody2D _rigidbody;
    private bool _onPause;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = Vector2.up * _jumpForce;
        }

        if(!_onPause)
        {
            RotateBird();
        }
    }

    private void RotateBird()
    {
        float targetAngle;

        if (_rigidbody.velocity.y > -0.5)
        {
            targetAngle = _maxRotation;
        }
        else
        {
            targetAngle = _minRotation;
        }

        float angle = Mathf.LerpAngle(transform.rotation.eulerAngles.z, 
            targetAngle, _rotationSpeed * Time.deltaTime * 2);

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public override void OnPause()
    {
        _onPause = true;
        _rigidbody.isKinematic = true;
    }

    public override void OnResume()
    {
        _onPause = false;
        _rigidbody.isKinematic = false;
    }
}
