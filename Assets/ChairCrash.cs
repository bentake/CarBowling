using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairCrash : MonoBehaviour
{
    public AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        AS.Play();
    }
}

