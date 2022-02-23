using System.Collections ;
using System.Collections.Generic ;
using UnityEngine ;
using UnityEngine.SceneManagement ;
public class GameEndManagement : MonoBehaviour
{
    GameObject Chiina ;
    // Start is called before the first frame update
    void Start ()
    {
        Chiina = GameObject.FindGameObjectWithTag ("Chiina") ;
    }
    // Update is called once per frame
    void Update ()
    {
        if (Chiina.activeSelf == false)
            LancerJeu () ;
    }
    public void LancerJeu ()
    {
        SceneManager.LoadScene ("Menu") ;
    }
}
