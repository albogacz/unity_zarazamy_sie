using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SphereIntersectionCollider : MonoBehaviour
{
    [SerializeField] private GameObject sphere;
    public Material intersect;
    public Material not_intersected;
    void OnTriggerEnter(Collider other){
        if(other.tag == "wirus"){
            sphere.GetComponent<Renderer>().material = intersect;
            //not_intersected.SetColor("_Color", Color.red);
            //sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
    }


    void OnTriggerExit(Collider other){
        if(other.tag == "wirus"){
            sphere.GetComponent<Renderer>().material = not_intersected;
            //sphere.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        sphere.GetComponent<Renderer>().material = not_intersected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
