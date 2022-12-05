using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeDown : MonoBehaviour
{
    private float _time = 60;
    private TextMeshProUGUI timeText;
    private GameManagerX _gameStat;

    private void Start()
    {
        timeText = GetComponent<TextMeshProUGUI>();
        _gameStat = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    private void Update()
    {
        timeText.text = "Time: " + Convert.ToInt32(_time);
        if (_gameStat.isGameActive) _time -= Time.deltaTime;
        if (Convert.ToInt32(_time) == 0) _gameStat.GameOver();
    }
}
