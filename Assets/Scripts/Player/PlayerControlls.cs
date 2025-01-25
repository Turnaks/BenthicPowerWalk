using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControlls : MonoBehaviour
{
    [SerializeField]
    private float _speed = 1;

    [SerializeField]
    private float _maxSpeed = 3;

    [SerializeField]
    private float _motion;

    [SerializeField]
    private float _motionThreshhold;

    [SerializeField]
    private float _slowDownRate = 0.5f;

    [SerializeField]
    private float _jumpForce = 100;

    [SerializeField]
    private bool _canJump = true;

    private Rigidbody2D _rb;

    [SerializeField]
    private ContactFilter2D _filter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    public void OnWalk(InputAction.CallbackContext context)
    {
        _motion = context.ReadValue<float>();
    }

    private void Walk()
    {
        if(_motion > _motionThreshhold | _motion < _motionThreshhold)
        {
            _rb.linearVelocityX += _motion * _speed;
            _rb.linearVelocityX = Mathf.Clamp(_rb.linearVelocityX, -_maxSpeed, _maxSpeed);
        }
        else
        {
            _rb.linearVelocityX = _rb.linearVelocityX * _slowDownRate;
        }
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (_canJump)
        {
            _rb.AddForce(Vector2.up * _jumpForce);
            _canJump = false;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision == null)
            return;

        
        if (GetComponent<Collider2D>().IsTouching(collision.collider, _filter))
        {
            _canJump = true;
        }
    }
}