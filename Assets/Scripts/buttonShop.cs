﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonShop : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OpenPanel()
    {
      if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }
    }
}
