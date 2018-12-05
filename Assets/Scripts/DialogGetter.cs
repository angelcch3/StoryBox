using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections.Generic;

namespace StoryBoxVR
{
    public class DialogGetter : MonoBehaviour
    {
        public float waitTime = 6f;
        public Text textBox;
        public string[] dialogs;
        public float timer;
        public int count;
        public SentimentHelper sHelper;

        public void Start()
        {
            this.MakeArray();
            textBox = gameObject.GetComponent<Text>();
            textBox.text = dialogs[count];
            count = 0;
            timer = 0f;
        }


        // Use this for initialization
        public void MakeArray()
        {
            dialogs = new string[] {"Dad , someone will come to help you soon okay ?",
            "My name is Martin Gonzalez , and I will not be oppressed any longer !",
                "I 'm not sure I 'm sure of it",
                "Martin , let 's go !",
                "I can not do this any longer ...",
                "You know what happens to those who oppose",
                "Unfortunately Freedom has a cost",
                "We are the only two left",
            "Please be on one of those ships",
            "I 'm scared of the fact that I 'm afraid of the truth",
            "You know this is a bad place .",
                "I 'm scared of the fact that I 'm afraid of the truth",
                "We 're in plain sight out here .",
                "You 're not going to go to jail",
            "You need to tell me what to do ."};
        }

        private void Update()
        {
            timer += Time.deltaTime;
            if (timer > waitTime && count < 14)
            {
                textBox.text = dialogs[count];
                count += 1;
                int random = UnityEngine.Random.Range(0, 3);
                switch(random){
                    case 1:
                        sHelper.makeAngry();
                        GameObject instance = Instantiate(Resources.Load("GreenJelly", typeof(GameObject))) as GameObject;
                        break;
                    case 2:
                        sHelper.makeSad();
                        GameObject instance1 = Instantiate(Resources.Load("RedJelly", typeof(GameObject))) as GameObject;
                        break;
                    case 3:
                        sHelper.makeHappy();
                        GameObject instance3 = Instantiate(Resources.Load("RedJelly", typeof(GameObject))) as GameObject;
                        break;
                }
                timer = 0f;
            }
        }
    }
}
