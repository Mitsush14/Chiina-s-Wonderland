using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    GameObject Chiina;
    // Start is called before the first frame update
    void Start()
    {
        Chiina = GameObject.FindGameObjectWithTag ("Chiina") ;
    }

    // Update is called once per frame
    void Update()
    {
        //pas obligé de le garder, ça sert de débugage
        Debug.Log("Compteur de Chiina : " + Chiina.GetComponent<grandir>().getCompteur().ToString());
        if(!Chiina.activeSelf){
            Debug.Log("This is ~~the end~~ SPARTA");
        }
    }
}