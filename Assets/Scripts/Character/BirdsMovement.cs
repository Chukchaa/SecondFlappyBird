using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdsMovement : MonoBehaviour
{
    [SerializeField] private float _jumpForce = 5f;
    [SerializeField] private float _rotationSpeed = 5f;

    private float _maxRotation = 45;
    private float _minRotation = -75;
    private Rigidbody2D _rigidbody;

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

        RotateBird();
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
}
