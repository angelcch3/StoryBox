using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace StoryBoxVR
{
    public class PlayerNames : MonoBehaviour
    {
        GameObject[] playerNameText;
        int count;

        // Use this for initialization
        void Start()
        {
            count = 0;
            playerNameText = GameObject.FindGameObjectsWithTag("PlayerNameText");
        }

        public void updatePlayer(string playerName) {
            if (count < 3) {
                Text textRef = playerNameText[count].GetComponent<Text>();
                textRef.text = playerName;
                count = count + 1;
            }
        }
    }
}
