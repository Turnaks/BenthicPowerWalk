using Unity.VisualScripting;
using UnityEngine;

public class TerritoryCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject _crab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
            _crab.GetComponent<CrabBehaviour>().Alert(collision.gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            _crab.GetComponent<CrabBehaviour>().Calm();
    }
}
