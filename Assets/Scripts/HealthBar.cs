﻿using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    private float fillAmount = 100.0f;
    private float lerpSpeed = 10.0f;

    [SerializeField]
    private Image image;

    public float MaxValue { get; set; }
    public float Value { set { fillAmount = Map(value, 0, MaxValue, 0, 1); } }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        HandleBar();	
	}

    private void HandleBar()
    {
        if (fillAmount != image.fillAmount)
        {
            image.fillAmount = Mathf.Lerp(image.fillAmount, fillAmount, Time.deltaTime * lerpSpeed);
        }        
    }

    private float Map(float value, float inMin, float inMax, float outMin, float outMax)
    {
        return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
    }
}
