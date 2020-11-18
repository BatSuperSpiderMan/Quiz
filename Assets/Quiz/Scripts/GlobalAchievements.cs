using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAchievements : MonoBehaviour
{
    //General Variables
    public GameObject achNote;
    public AudioSource achSound;
    public bool achActive = false;
    public GameObject achTitle;
    public GameObject achDesc;

    //Achieventment 01 Specific
    public GameObject ach01Image;
    public static int ach01Count;
    public int ach01Trigger = 5;
    public int ach01Code;


    // Update is called once per frame
    void Update()
    {
        /* ach01Code = PlayerPrefs.GetInt("Ach01");
         StartCoroutine(Trigger01Ach());/*
     }

     public void run()
     {
         ach01Code = PlayerPrefs.GetInt("Ach01");
         StartCoroutine(Trigger01Ach());
     }

     /*IEnumerator Trigger01Ach()
     {
        /* achActive = true;
         ach01Code = 12345;
         PlayerPrefs.SetInt("Ach01", ach01Code);
         achSound.Play();
         ach01Image.SetActive(true);
         achTitle.GetComponent<Text>().text = "CONGRATULATIONS!!!";
         achDesc.GetComponent<Text>().text = "You have scored more than 50% required for this challenge.";
         achNote.SetActive(true);
         yield return new WaitForSeconds(7);
         //resetting UI
         achNote.SetActive(false);
         ach01Image.SetActive(false);
         achTitle.GetComponent<Text>().text = string.Empty;
         achDesc.GetComponent<Text>().text = string.Empty;
         achActive = false;
     }*/
    }
}
