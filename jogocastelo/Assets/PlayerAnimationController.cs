using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimationController : MonoBehaviour
{
   public Animation PlayerAnimator;

   public void PlayerAnimation(string animationName)
   {
    PlayerAnimator.Play(animationName);
   }
}
