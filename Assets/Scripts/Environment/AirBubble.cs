using System.Collections;
using UnityEngine;

public class AirBubble : MonoBehaviour
{
    [SerializeField]
    private float _airGain;

    [SerializeField]
    private Collider2D _trigger;

    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private float _bubbleCooldown = 20.0f;

    private float _bubbleTimer;

    public void Update()
    {
        BubbleCheck();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
            return;

        if (!collision.gameObject.TryGetComponent<Air>(out Air air))
            return;

        air.GainAir(_airGain);
    }

    private void BubblePop()
    {
        _bubbleTimer = _bubbleCooldown;
        _trigger.enabled = false;
        _spriteRenderer.enabled = false;
    }

    private void BubbleCheck()
    {
        if (_bubbleTimer > 0)
        {
            _bubbleTimer -= Time.deltaTime;
        }
        if (_bubbleTimer < 0)
        {
            _trigger.enabled = true;
            _spriteRenderer.enabled = true;
        }
    }

}
