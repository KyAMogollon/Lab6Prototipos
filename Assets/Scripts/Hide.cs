using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class Hide : MonoBehaviour
{
    public static event Action onHide;
    public static event Action isHide;
    [SerializeField] PlayerController player;


    public void OnHide()
    {
       onHide?.Invoke();
    }
    public void OnPressHide()
    {
       isHide?.Invoke();
    }
}
