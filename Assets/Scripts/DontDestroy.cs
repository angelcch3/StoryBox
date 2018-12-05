using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StoryBoxVR
{
    public class DontDestroy : MonoBehaviour
    {

        private static bool created = false;
        // Make sure that the camera doesn't die when you switch scenes
        void Awake()
        {
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}