/*
 * Adam Field
 * Assignment 6
 * weapon framework
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
    }

    protected void EnemyEatsWeapon(Enemy enemy)
    {
        Debug.Log("enemy eats weapon");
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    public void Recharge()
    {
        Debug.Log("recharging weapon");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
