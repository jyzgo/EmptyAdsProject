﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CloseTouch : MonoBehaviour {

    public void OnMouseUp()
    {

            closeEvent.Invoke();
        

    }

    public UnityEvent closeEvent;
}
