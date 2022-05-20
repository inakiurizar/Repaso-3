using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instantiate : MonoBehaviour
{
    public Text cantMaxClones;
    public GameObject objetoClonar;
    public int counter;
    public Text clonRestantes;
    public InputField Ifield;
    GameObject clon;


    void Start()
    {
        counter = 0;
        clonRestantes.text = "";
    }

    public void clonar()
    {
        if (cantMaxClones.text != "")
        {
            Ifield.readOnly = true;
            int cloneAmount = int.Parse(cantMaxClones.text);
            if (counter < cloneAmount)
            {
                clon = Instantiate(objetoClonar);
                counter++;
                clonRestantes.text = (cloneAmount - counter).ToString();
                Destroy(clon, 2);
            }
            else
            {
                clonRestantes.text = "Error. No hay mas";
            }
        } 
        else
        {
            clonRestantes.text = "Error. Ingrese un valor";
        }
        
    }
}
