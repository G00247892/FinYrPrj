﻿using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

    public float TotalHp;
    public float CurrentHp;

	// Use this for initialization
	void Start () {
        CurrentHp = TotalHp;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            TakeDamage();
        }
	}

    void TakeDamage()
    {
        CurrentHp -= 5;
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
    }
}
