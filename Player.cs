using UnityEngine;

public class Player: MonoBehaviour
{
    private int health = 10;
    public void TakeDamage(int damage)
    {
        health += damage;
        print("Player's health: " + health);
    }
}
