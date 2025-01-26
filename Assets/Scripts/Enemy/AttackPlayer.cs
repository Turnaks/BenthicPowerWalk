using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField]
    float attackStrength;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
            return;

        if(collision.gameObject.TryGetComponent<Air>(out Air air))
            air.LooseAir(attackStrength);
    }
}
