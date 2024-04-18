using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{
    public static event Action onHide;
    public Button butonHide;
    [SerializeField] PlayerController player;
    
    // Start is called before the first frame update
    void Start()
    {
        onHide = OnHide;
    }
    public void Update()
    {
        if (player.life == 1)
        {
            onHide?.Invoke();
            Debug.Log("Me activo");
        }
    }
    public void OnHide()
    {
        butonHide.gameObject.SetActive(true);
       
    }
    public void OnPressHide()
    {
        StartCoroutine(TimeToHide());
    }
    IEnumerator TimeToHide()
    {
        player.canDamage = false;
        yield return new WaitForSecondsRealtime(3.00f);
        player.canDamage = true;
    }
}
