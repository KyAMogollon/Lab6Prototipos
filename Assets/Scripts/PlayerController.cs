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
        Hide.isHide += Coroutine;
    }
    public void OnAttackEnemy()
    {
        HealthSystem.ModifyHealth?.Invoke(damage, id);
    }
    public void Coroutine()
    {
        StartCoroutine(TimeToHide());
    }
    IEnumerator TimeToHide()
    {
        canDamage = false;
        yield return new WaitForSecondsRealtime(3.00f);
        canDamage = true;
    }
}
