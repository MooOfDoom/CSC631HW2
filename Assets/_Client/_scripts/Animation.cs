using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Animation : MonoBehaviour
{

    [SerializeField]
    private GameObject _player;//taking reference for player

    private Animator _playerAnimator;


    private void Start()
    {
        _playerAnimator = _player.GetComponent<Animator>();//getting the animator component from player game object
    }


    //method for animation button
    public void AnimationButtonClicked()
    {
        _playerAnimator.Play("test");//playing the test animation..test is the name of the animation, animation name must be same 
    }






}
