using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour
{
    // Este m�todo se llamar� cuando se presione el bot�n
    public void QuitGame()
    {
        // Si estamos en el editor de Unity, detener la reproducci�n
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // Si estamos en una compilaci�n, cerrar la aplicaci�n
        Application.Quit();
#endif
    }
}
