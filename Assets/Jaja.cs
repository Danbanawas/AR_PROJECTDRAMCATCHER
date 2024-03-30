using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Jaja : MonoBehaviour
{

    [SerializeField] private GameObject imagecreator;
    [SerializeField] private Vector3 imageoffset;
    // Start is called before the first frame update

    private GameObject albumbutter;
    private ARTrackedImageManager artracker;
    private void OnEnable()
    {
        artracker=gameObject.GetComponent<ARTrackedImageManager>();
        artracker.trackedImagesChanged += onimagechange;
    }

    // Update is called once per frame
    private void onimagechange(ARTrackedImagesChangedEventArgs obj) { 
    foreach (ARTrackedImage image in obj.added)
        {
            albumbutter = Instantiate(imagecreator, image.transform);
            albumbutter.transform.position += imageoffset;
        
        
        }
    
    
    }
    
}
