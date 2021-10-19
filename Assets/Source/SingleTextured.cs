using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTextured : MonoBehaviour
{
    void Start()
    {
        // set material at runtime
        Material mat = Resources.Load("TestMat", typeof(Material)) as Material;
        GameObject smaple = GameObject.Find("Sphere");
        smaple.GetComponent<MeshRenderer>().material = mat;
    }
}
