using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gemas_Manager : MonoBehaviour
{
    public GameObject imagenGema;
    void OnTriggerEnter(Collider c){
        if (c.gameObject.name=="GemaAzul"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenGema.SetActive(true);
            //3. Añadimos al inventario
            GetComponent<Inventario>().AddItem(c.gameObject);
        }

        if (c.gameObject.name=="GemaMorada"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenGema.SetActive(true);
            GetComponent<Inventario>().AddItem(c.gameObject);
    }

    if (c.gameObject.name=="GemaGreen"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenGema.SetActive(true);
            GetComponent<Inventario>().AddItem(c.gameObject);
}

        if (c.gameObject.name=="GemaRed"){
            //1. Desaparece la llave
            Destroy(c.gameObject);
            //2. Aparece en la interfaz de usuario
            imagenGema.SetActive(true);
            GetComponent<Inventario>().AddItem(c.gameObject);
}
}
}
