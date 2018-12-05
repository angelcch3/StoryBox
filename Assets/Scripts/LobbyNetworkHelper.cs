using UnityEngine;
using System.Collections;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

namespace StoryBoxVR
{
    public class LobbyNetworkHelper : MonoBehaviour
    {
        public PlayerNames playerNamesManager;

        void HandleValueChanged(object sender, ValueChangedEventArgs args)
        {
            if (args.DatabaseError != null)
            {
                Debug.LogError(args.DatabaseError.Message);
                return;
            }
            DataSnapshot playerData = args.Snapshot;
            // playerNamesManager.updatePlayer()

            int count = 0;
            foreach (DataSnapshot child in playerData.Children) 
            {
                 foreach (DataSnapshot grandchild in child.Children) {
                    string playerName = grandchild.GetValue(true).ToString();
                    if (count < 2) {
                        playerNamesManager.updatePlayer(grandchild.GetValue(true).ToString());
                        count += 1;
                    }
                 }
            }
        }

        // Use this for initialization
        void Start()
        {
            FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://storybox-hackmit.firebaseio.com/");
            Firebase.Database.DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
            // Set a flag here indicating that Firebase is ready to use by your
            // application.
            Debug.Log("Firebase is ready to go!");
        }

        // Update is called once per frame
        void Update()
        {
            FirebaseDatabase.DefaultInstance.GetReference("/users").ValueChanged += HandleValueChanged;
        }
    }
}
