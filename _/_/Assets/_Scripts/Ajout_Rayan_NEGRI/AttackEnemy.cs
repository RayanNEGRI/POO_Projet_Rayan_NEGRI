using UnityEngine;

public class AttackEnemy : MonoBehaviour
{

    [SerializeField] int damage = 10;

    void OnTriggerEnter(Collider player)
    {
        if (player.tag == "Player")
        {
            player.SendMessage("TakeDamage", damage);
            Debug.Log("Le joueur prend un degats");
        }
    }
}


