using Unity.VisualScripting;
using UnityEngine;

public class TerritoryCheck : MonoBehaviour
{
    public bool PlayerInTerritory = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
            PlayerInTerritory=true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            PlayerInTerritory = false;
    }
}
