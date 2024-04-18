using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text playerLife;
    public TMP_Text enemyLife;
    public static Action<int, string> updateLifeText;
    // Start is called before the first frame update
    void Start()
    {
        updateLifeText = UpdateLifeText; 
    }
    public void UpdateLifeText(int vida, string ID)
    {
        if (ID == "Player")
        {
            playerLife.text = "Life: " + vida;
            
        }else if (ID == "Enemy")
        {
            enemyLife.text = "Life: " + vida;
        }
    }
}
