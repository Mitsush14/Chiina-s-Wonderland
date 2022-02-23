using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tp_ennemis : MonoBehaviour
{   //Création d'un tableau qui contient tous les ennemis
    GameObject [] toutEnnemi = new GameObject [3] ;
    GameObject Chiina ;
    // Start is called before the first frame update
    void Start ()
    {   //On met les ennemis dans le tableau
        toutEnnemi [0] = GameObject.FindGameObjectWithTag ("Cube") ;
        toutEnnemi [1] = GameObject.FindGameObjectWithTag ("GreenQuad") ;
        toutEnnemi [2] = GameObject.FindGameObjectWithTag ("BlueQuad") ;
        Chiina = GameObject.FindGameObjectWithTag ("Chiina") ;
    }
    // Update is called once per frame
    void Update ()
    {   //On regarde si un ennemi est désactivé, si oui, on va gérer leur respawn
        foreach (GameObject ennemiCourant in toutEnnemi)
            if (ennemiCourant.activeSelf == false)
                StartCoroutine (waiter (ennemiCourant)) ;
    }
    IEnumerator waiter (GameObject ennemiCourant)
    {   //On gère la position aléatoire du respawn
        ennemiCourant.transform.position = new Vector3 (Random.Range (-13.9f , 13.9f) , 1f, Random.Range(-13.9f, 13.9f)) ;
        //On gère la taille aléatoire attribué lors du respawn
        Vector3 ennemiScale = Chiina.transform.localScale ;
        float scaleRand = Random.Range(0.75f, 2f);
        ennemiCourant.transform.localScale = new Vector3 (ennemiScale.x * scaleRand , ennemiScale.y * scaleRand , ennemiScale.z * scaleRand);
        //On attend un temps aléatoire avant le respawn
        yield return new WaitForSeconds (Random.Range (2f , 6f)) ;
        //On réactive l'ennemi
        ennemiCourant.SetActive (true) ;
    }
}
