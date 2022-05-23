using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    public TMP_Text countTxt;
    int cookieCount;
    int bonus = 0;
    private void Start()
    {
        cookieCount = 10;
    }
    private void OnMouseDown()
    {
        cookieCount++;
        cookieCount += bonus;
        countTxt.text = "Cookies: " + cookieCount;
    }
    private void Update()
    {
        //Use U to upgrade clicker
        if(cookieCount>20 && Input.GetKeyDown(KeyCode.U))
        {
            cookieCount -= 20;
            countTxt.text = "Cookies: " + cookieCount;
            bonus += 1;
        }
    }
}
