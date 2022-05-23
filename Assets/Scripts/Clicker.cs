using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    public TMP_Text countTxt;
    int cookieCount;
    private void Start()
    {
        cookieCount = 10;
    }
    private void OnMouseDown()
    {
        cookieCount++;
        countTxt.text = "Cookies: " + cookieCount;
    }
}
