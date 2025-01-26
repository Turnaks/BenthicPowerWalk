using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    float attackStrength;

    Air playerAir;

    private void Start()
    {
        playerAir = player.GetComponent<Air>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            playerAir.LooseAir(attackStrength);
    }
}
