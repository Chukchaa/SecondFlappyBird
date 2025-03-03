using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2f;
    [SerializeField] private float _order = -10f;

    private void Update()
    {
        transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);

        if (transform.position.x < _order)
            Destroy(gameObject);
    }
}
