using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    /*public GameObject seanChar;
    public GameObject jeffChar;
    public GameObject anthonyChar;
    public GameObject otherGuyChar;*/
    public GameObject girlChar;

    /*public Animator seanAnima;
    public Animator jeffAnima;
    public Animator anthonyAnima;
    public Animator otherGuyAnima;*/
    public Animator girlAnima;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello");
        /*var distance1 = Vector3.Distance(transform.position, seanChar.transform.position);
        var distance2 = Vector3.Distance(transform.position, jeffChar.transform.position);
        var distance3 = Vector3.Distance(transform.position, anthonyChar.transform.position);
        var distance4 = Vector3.Distance(transform.position, otherGuyChar.transform.position);*/
        var distance5 = Vector3.Distance(transform.position, girlChar.transform.position);

        Debug.Log(distance5);
        if (distance5 < 3) {
            girlAnima.SetTrigger("New Trigger");
            Debug.Log("Girl Triggered");
        }
    }
}
