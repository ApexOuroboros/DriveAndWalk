using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneToVeh : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(2);
    }
}
