
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class TouchPhaseDisplay : MonoBehaviour
{
    //public Text phaseDisplayText;
    //private Touch theTouch;
    // private float timeTouchEnded;
    //private float displayTime = .5f;
    public GameObject circle;
    public GameObject staraura;
    public GameObject picangel;
    public GameObject picdevil;
    public GameObject picangel2;
    public GameObject picdevil2;


    public AudioSource audioData;

    private void Start()
    {
        audioData = GetComponent<AudioSource>();
         
        
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            //theTouch = Input.GetTouch(0);
            //phaseDisplayText.text = theTouch.phase.ToString();
            circle.gameObject.SetActive(true);
            staraura.gameObject.SetActive(true);
            picangel.gameObject.SetActive(true);
            picdevil.gameObject.SetActive(true);
            picangel2.gameObject.SetActive(true);
            picdevil2.gameObject.SetActive(true);

            audioData.Pause();
            




        }

      

    }
}
