using System.Runtime.CompilerServices;
using UnityEngine;

public class SeeIgel : MonoBehaviour
{
    [SerializeField]
    private float _attackPower = 15.0f;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision == null)
            return;

        if (collision.gameObject.tag != "Player")
            return;

        if (!collision.gameObject.TryGetComponent<Air>(out Air air))
            return;

        air.GainAir(-_attackPower);

        if (!collision.gameObject.TryGetComponent<PlayerControlls>(out PlayerControlls plCon))
            return;

        plCon.BackTrack();
    }
}
