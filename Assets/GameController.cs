using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{

        public GameObject gameOver;

        public static GameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

        public void ShowGameOver(){
        gameOver.SetActive(true);
    }

        public void RestartGame(string lvlName){
        SceneManager.LoadScene(lvlName);
        Debug.Log(" recarregar pagina");
    }
}
