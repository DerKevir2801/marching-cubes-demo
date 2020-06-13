using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ermöglicht per Tastatureingabe Würfel im oder gegen dem Uhrzeigersinn zu drehen
public class CubeRotation : MonoBehaviour
{
    void Update()
    {

         if (Input.GetKeyDown(KeyCode.A))  //Um 10 Grad im Uhrzeigersinn drehen
         {
            transform.Rotate(0, 15, 0);
         }

         if (Input.GetKeyDown(KeyCode.D))  //Um 10 Grad gegen dem Uhrezeigersinn drehen
         {
            transform.Rotate(0, -15, 0);
         }

    }


}
