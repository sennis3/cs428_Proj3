using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCan : MonoBehaviour
{
    public Transform startPos;
    public GameObject sodaCan;

    // Start is called before the first frame update
    void Start()
    {
        //public static Object Instantiate(sodaCan, startPos.position, startPos.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnCan()
    {
        Instantiate(sodaCan, startPos.position, startPos.rotation);
    }
}
