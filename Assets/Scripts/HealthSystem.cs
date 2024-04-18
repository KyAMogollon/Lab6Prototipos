using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public static Action<int,string> ModifyHealth;
    [SerializeField] PlayerController player;
    [SerializeField] EnemyController enemy;
    // Start is called before the first frame update
    void Start()
    {
        ModifyHealth = OnAttack;
    }
    public void OnAttack(int damage,string ID)
    {
        if (ID == "Player" )
        {
            enemy.life -= damage;
            GameManager.updateLifeText?.Invoke(enemy.life,"Enemy");
        }else if (ID == "Enemy" && player.canDamage == true)
        {
            player.life -= damage;
            GameManager.updateLifeText?.Invoke(player.life, "Player");

        }
    }

}
