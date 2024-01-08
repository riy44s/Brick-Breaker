using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI Score;

    public void plus()
    {
        points++;
        Score.text = points.ToString();
    }
    public void minus()
    {
        points--;
        Score.text = points.ToString();
    }
}
