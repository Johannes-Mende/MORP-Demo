using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAndMovementController : MonoBehaviour
{
    //https://www.youtube.com/watch?v=bXNFxQpp2qk 11:39     https://www.youtube.com/watch?v=FbM4CkqtOuA
    PlayerInput playerInput;

    void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.CharacterControls.Move.started += context => { Debug.Log(context.ReadValue<Vector2>()); };
    }


    void Update()
    {
        
    }
}
