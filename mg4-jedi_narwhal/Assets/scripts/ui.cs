using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ui : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _pointstext;






    void Start()
    {
        gamecontroller.Instance.Score+= HandlePoints;
    }

    // Update is called once per frame  
    void HandlePoints(int _points)
    {
        _pointstext.text= "Score:"+_points.ToString();
    }
}
