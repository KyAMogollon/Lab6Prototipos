using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public static Action<int,string> ModifyHealth;
    [SerializeField] PlayerController player;
    [SerializeField] EnemyController enemy;
    [SerializeField] Hide hide;
    // Start is called before the first frame update
    void Start()
    {
        ModifyHealth = OnAttack;
        GameManager.updateLifeText?.Invoke(enemy.life, "Enemy");
        GameManager.updateLifeText?.Invoke(player.life, "Player");
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
            if (player.life == 1)
            {
                hide.OnHide();
            }
            GameManager.updateLifeText?.Invoke(player.life, "Player");

        }
    }

}
