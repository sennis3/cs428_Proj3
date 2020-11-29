using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlScript : MonoBehaviour
{

    public AudioSource audiosrc;
    public Animator anima;
    // Start is called before the first frame update
    void Start()
    {
        audiosrc.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider colObj) {
        if (colObj.gameObject.name == "CameraTrigger") {
            anima.SetTrigger("GirlTrigger");
            audiosrc.Play();
        }
    }
}
