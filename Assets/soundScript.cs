using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundScript : MonoBehaviour
{
    public AudioSource src;
    // Start is called before the first frame update
    void Start()
    {
        src = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void figure(){
       src.Play();
    }
}
