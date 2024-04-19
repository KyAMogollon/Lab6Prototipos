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
    public TMP_Text hideText;
    public Button buttonHide;
    public static Action<int, string> updateLifeText;
    // Start is called before the first frame update
    void Start()
    {
        updateLifeText = UpdateLifeText;
        Hide.onHide += ActivateHide;
        Hide.isHide += AppearTextHide;
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
    public void ActivateHide()
    {
        buttonHide.gameObject.SetActive(true);
    }
    public void AppearTextHide()
    {
        StartCoroutine(AppearAndDesAppear());
    }
    IEnumerator AppearAndDesAppear()
    {
        hideText.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(3.00f);
        hideText.gameObject.SetActive(false);

    }
}
