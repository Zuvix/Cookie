using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    public TMP_Text countTxt;
    int count;
    private void Start()
    {
        count = 0;
    }
    private void OnMouseDown()
    {
        count++;
        countTxt.text = "Cookies: " + count;
    }
}
