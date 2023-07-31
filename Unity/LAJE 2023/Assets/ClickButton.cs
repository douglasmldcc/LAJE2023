using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] private string nomeProximaCena =  "Lobby";

    public void avancaCena()
    {
        SceneManager.LoadScene(nomeProximaCena);
    }

}
