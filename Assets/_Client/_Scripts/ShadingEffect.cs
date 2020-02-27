using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadingEffect : MonoBehaviour
{

    private GameObject Sun;

    private Transform _sunTransform;

    public float _rotaionValue = 10f;//change rotaion value for the how much time it will take to transition


    private void Awake()
    {
        gameObject.SetActive(false);//on start the effect will now affect the scene

        Sun = GameObject.FindGameObjectWithTag("Sun");//first setting the directional light tag to sun then finding it with the method
        //sun could be public . on that case you have drag and drop the sun 
    }

    private void Start()
    {
        _sunTransform = Sun.GetComponent<Transform>();//getting the transform of the directional light
    }

    private void Update()
    {
        _sunTransform.Rotate(_rotaionValue*Time.deltaTime,0,0);//updating the rotation value of the directional light of the scene
        /*
         * here multiplaying with time.delta time to make it smooth
         * 
         */
    }


    public void ShadingEffectButtonClicked()
    {
        gameObject.SetActive(true);//on shading button clicked the day to night effect will take place
    }




}
