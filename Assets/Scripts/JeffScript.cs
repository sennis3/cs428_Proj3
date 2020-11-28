using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeffScript : MonoBehaviour
{
    //public AudioSource audioSrc;
    public Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        //audiosrc.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider colObj) {
        if (colObj.gameObject.name == "CameraTrigger") {
            anima.SetTrigger("JeffTrigger");
            //audiosrc.Play();
        }
    }
}
