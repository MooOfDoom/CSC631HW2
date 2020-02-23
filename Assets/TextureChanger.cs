using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureChanger : MonoBehaviour
{

    public Material mat;
    public Material altMat;
    public MeshRenderer player;



    private bool toggle = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("this is the player's material: " + mat);
        player.material = mat;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("c"))
        {
            if(toggle)
            {
                player.material = altMat;
                toggle = false;
            }
            else
            {
                player.material = mat;
                toggle = true;
            }
            Debug.Log("the c key is pressed");
        }
    }
}
