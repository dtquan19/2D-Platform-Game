using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    [SerializeField] private Text countText;
    [SerializeField] private AudioSource collectAudio;
    private int countMelon = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "fruit")
        {
            collectAudio.Play();
            countMelon++;
            countText.text = "Melon: " + countMelon;
            Destroy(other.gameObject);
        }
    }
}
