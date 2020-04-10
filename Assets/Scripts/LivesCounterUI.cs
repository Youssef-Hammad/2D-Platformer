﻿using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof(Text))]
public class LivesCounterUI : MonoBehaviour
{
    [SerializeField]
    private Text livesText;

    // Start is called before the first frame update
    void Awake()
    {
        livesText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = (GameMaster.RemainingLives).ToString();
    }
}
