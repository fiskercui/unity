﻿using UnityEngine;
using System.Collections;

using UnityEngine.EventSystems;

public class ImageHandler : MonoBehaviour,IPointerClickHandler
{

	// Use this for initialization
	void Start () {
	
	}   
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick hehehehehehe");
    }
}
