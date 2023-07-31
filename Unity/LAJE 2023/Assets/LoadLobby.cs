using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltaLobby : MonoBehaviour
{

    public void JogarNovamente()
    {
        SceneManager.LoadScene("Lobby");
    }
}
