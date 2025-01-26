using UnityEngine;

public class AirBubble : MonoBehaviour
{

    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject bubble;

    [SerializeField]
    float airGain;

    Air playerAir;
    void Start()
    {
        playerAir = player.GetComponent<Air>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
            playerAir.GainAir(airGain);
    }

}
