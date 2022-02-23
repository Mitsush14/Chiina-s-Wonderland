using System.Collections ;
using System.Collections.Generic ;
using UnityEngine ;
using UnityEngine.SceneManagement ;
public class GameMenuManagement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Application.targetFrameRate = 60;
    }
    // Update is called once per frame
    void Update() {}
    public void LancerJeu ()
    {
        SceneManager.LoadScene ("Jeu") ;
    }
    public void Regles ()
    {
        SceneManager.LoadScene("Regles") ;
    }
    public void Retour ()
    {
        SceneManager.LoadScene("Menu") ;
    }
    public void Quitter ()
    {
        Application.Quit () ;
    }
}
