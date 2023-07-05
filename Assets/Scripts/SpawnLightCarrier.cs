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

    public class SpawnLightCarrier : MonoBehaviour
    {
        public GameObject followerPrefab;

        public void SpawnFollower()
        {
            Instantiate(followerPrefab, transform.position, Quaternion.identity);

            Destroy(gameObject);

        }

    }
}