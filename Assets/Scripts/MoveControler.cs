using UnityEngine;

public class MoveControler : MonoBehaviour
{

    private InputResiver _inputresiver;

    [SerializeField] private float _speedX;
    [SerializeField] private float _jumpHeight;
    [SerializeField] private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _inputresiver = GetComponent<InputResiver>();
    }
    private void MovePl()
    {

        float xMove = _inputresiver.Move.x;

        if (_inputresiver.JumpPresed)
        {
            _rb.AddForce(Vector2.up * _jumpHeight);
        }

        //float yMove = _inputresiver.Move.y;
        transform.position += new Vector3(xMove * _speedX, 0) * Time.deltaTime;


    }
    private void FixedUpdate()
    {
        MovePl();
    }

}
