using System.Dynamic;
using UnityEngine;

public class CrabBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject _player;
    [SerializeField]
    Rigidbody2D _enemyRB;
    [SerializeField]
    float _enemySpeed;

    private bool _isAlerted;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (_isAlerted)
            moveTowardPlayer();
        else
            rest();
    }

    public void Alert(GameObject player)
    {
        _isAlerted = true;
        _player = player;
    }

    public void Calm()
    {
        _isAlerted = false;
    }

    void moveTowardPlayer()
    {
        if (_player.transform.position.x < transform.position.x)
            _enemyRB.linearVelocityX = -_enemySpeed;
        else
            _enemyRB.linearVelocityX = _enemySpeed;
    }
    void rest()
    {
        _enemyRB.linearVelocityX = 0;
    }
}
