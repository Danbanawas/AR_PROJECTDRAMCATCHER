using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Fadescript : MonoBehaviour
{
    public float fadeTime;
    private TextMeshProUGUI fadeAwayText;
    private RawImage FADEimage;
    public GameObject staraura;
    

    void Start()
    {
        fadeAwayText = GetComponent<TextMeshProUGUI>(); 
        FADEimage = GetComponent<RawImage>();
        staraura = GetComponent<GameObject>();
        
    }


    void Update()
    {
        if (fadeTime > 0)
        {
            fadeTime -= Time.deltaTime;
            fadeAwayText.color = new Color(fadeAwayText.color.r, fadeAwayText.color.g, fadeAwayText.color.b,fadeTime);
            FADEimage.color = new Color(FADEimage.color.r, FADEimage.color.g, FADEimage.color.b, fadeTime);
            staraura.SetActive(false);

        }
    }
}
