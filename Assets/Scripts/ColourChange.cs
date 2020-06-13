using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Eine Script, dass den Eckpunkten zugewiesen wird und die Farbe bzw. das Material des Eckpunktes verändert, wenn man auf den Eckpunkt draufklickt.
public class ColourChange : MonoBehaviour
{
    public Material[] materials;           //Erzeugung von einem Array mit Materialien
    public Renderer rend;                  //Ereugung eines Renderers, um die Materialien darstellen zulassen

    private int i = 1;                     //Laufvariable

    void Start()
    {
        rend = GetComponent<Renderer>();      //Zuordnung des Renderers zu rend
        rend.enabled = true;                  //Aktivierung der Darstellung
    }

    private void OnMouseDown()                        //Funktion für denn Fall, dass das zugewiesene Objekt angeklickt wird
    {
        if(materials.Length == 0)                     
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))               //"Falls mit linker Taste angeklickt, ändere das Material
        {
            i++;                                       //Inkrementierung der Laufvariable
            if(i > materials.Length)                   //Falls die Laufvariable größer wird als die Arraygröße, dann setze die Laufvariable wieder auf 1
            {
                i = 1;
            }

            rend.sharedMaterial = materials[i - 1];       //Zuweisung, welches Material angezeigt wird
        }
    }
}
