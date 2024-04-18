using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int life;
    public int damage;
    public string id;
    public bool canDamage;
    void Start()
    {
        id = tag;
        GameManager.updateLifeText?.Invoke(life, id);
        canDamage = true;
    }
    public void OnAttackEnemy()
    {
        HealthSystem.ModifyHealth?.Invoke(damage, id);
    }
}
