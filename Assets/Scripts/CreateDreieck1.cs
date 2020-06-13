using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class CreateDreieck1 : MonoBehaviour
{
    public Triangle triangle;
    public ColourChange colourChange;

    private bool isCreated;

    void Update()
    {
        Triangle triangle1 = null;
        if(colourChange.rend.sharedMaterial == colourChange.materials[0] && !isCreated) {
            triangle1 = Instantiate(triangle, transform.position, transform.rotation);
            isCreated = true;
        }
        if(colourChange.rend.sharedMaterial == colourChange.materials[1] && isCreated)
        {
            Destroy(triangle);
            isCreated = false;
        }
    }

}
