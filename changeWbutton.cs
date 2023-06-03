using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//MILAD

public class changeWbutton : MonoBehaviour
{

   public void ButtonMoveScene(string sceneName)
   {
    SceneManager.LoadScene(sceneName) ;
   }
   
}
