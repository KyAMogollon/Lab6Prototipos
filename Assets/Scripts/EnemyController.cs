using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int life;
    public int damage;
    public string id;
    // Start is called before the first frame update
    void Start()
    {
        id = tag;
        GameManager.updateLifeText?.Invoke(life, id);
    }

    // Update is called once per frame
    public void OnAttackAllied()
    {
        HealthSystem.ModifyHealth?.Invoke(damage, id);
    }
}
