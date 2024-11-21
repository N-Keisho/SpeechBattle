using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private int attack = 10;
    public int hand = -1;
    public bool isDead = false;
    public void damaged(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            isDead = true;
        }
    }
    public void randomHand()
    {
        hand = Random.Range(0, 3);
    }

    public void resetHand()
    {
        hand = -1;
    }
} 
