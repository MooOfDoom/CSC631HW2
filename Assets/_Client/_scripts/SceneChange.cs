using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    
    //for changing scene  add unityEngine.SceneManagent
    
        //its will take you the scene where a plance is created and added texture
    public void ChangeSceneButtonClicked()
    {
        SceneManager.LoadScene("scene2");
       // UnityEngine.SceneManagement.SceneManager.LoadScene("scene2"); you can call it this way in case you didn't add name space
    }



    //its will take you the scene where terrain is created and added texture
    public void TerrainSceneButtonClicked()
    {
        SceneManager.LoadScene("scene3");
    }


    //this method will be called from both scene2 and scene3
    public void GoToMainScene()
    {
        SceneManager.LoadScene("SampleScene");

        /*SceneManager.LoadScene(0);
         * you call call scene multiple way, here you can change it with build index
         * you can get the build index from file->build settings
         */
    }



}
