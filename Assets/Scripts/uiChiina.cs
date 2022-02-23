using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiChiina : MonoBehaviour
{
    GameObject Chiina;
    private static float ChiinaScale;
    [SerializeField]
    private Text ChiinaScaleText;
    [SerializeField]
    private Text ChiinaCompteur;

    // Start is called before the first frame update
    public void Start()
    {
        Chiina = GameObject.FindGameObjectWithTag("Chiina");
        ChiinaScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        ChiinaScaleText.text = "Taille de Chiina : " + ChiinaScale.ToString();
        ChiinaCompteur.text = "Compteur de Chiina : " + Chiina.GetComponent<grandir>().getCompteur().ToString();
    }

    public static void changeChiinaScale(float x){
        ChiinaScale = x;
    }
}
