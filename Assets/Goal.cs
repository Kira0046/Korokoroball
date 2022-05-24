using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject clearText;
    public GameObject nextButton;
    public AudioSource audioSouce;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ÉSÅ[Éã!");
        clearText.SetActive(true);
        nextButton.SetActive(true);
        audioSouce.Play();
    }
}
