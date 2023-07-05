using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CDF05
{
/// <summary>
/// the player will be presented with the chocie to accept help or not
/// if they say yes, it will spawn the follower
/// this game object will also need tobe destroyed
/// if they say no, this script won't be called
/// 
/// </summary>
/// 


    public class SpawnLightCarrier : MonoBehaviour
    {
        public GameObject followerPrefab;
        public GameObject lightCarrierPrefab;
        public Animator animator;

        private void Start()
        {
            followerPrefab.SetActive(false);
        }


        public void SetFollowerToActive()
        {
            followerPrefab.SetActive(true);
            lightCarrierPrefab.SetActive(false);
            animator.SetBool("isOpen", false);
        }

    }
}