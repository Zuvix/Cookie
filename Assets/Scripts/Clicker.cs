using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    public TMP_Text countTxt;
    int coookies;
    private void Start()
    {
        coookies = 0;
    }
    private void OnMouseDown()
    {
        coookies++;
        countTxt.text = "Cookies: " + coookies;
    }
}
