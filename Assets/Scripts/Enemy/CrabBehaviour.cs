using System.Dynamic;
using UnityEngine;

public class CrabBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject crab;
    [SerializeField]
    GameObject territory;
    [SerializeField]
    Rigidbody2D enemyRB;
    [SerializeField]
    float enemySpeed;

    TerritoryCheck territoryCheck;

    private void Start()
    {
        territoryCheck = territory.GetComponent<TerritoryCheck>();
    }
    // Update is called once per frame
    void Update()
    {
        if (territoryCheck.PlayerInTerritory)
            moveTowardPlayer();
        else
            rest();
    }

    void moveTowardPlayer()
    {
        if (player.transform.position.x < crab.transform.position.x)
            enemyRB.linearVelocityX = -enemySpeed;
        else
            enemyRB.linearVelocityX = enemySpeed;
    }
    void rest()
    {
        enemyRB.linearVelocityX = 0;
    }
}
