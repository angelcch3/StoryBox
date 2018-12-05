using UnityEngine;
using System.Collections;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class GametimeHelper : MonoBehaviour
{

    //void HandleValueChanged(object sender, ValueChangedEventArgs args)
    //{
    //    if (args.DatabaseError != null)
    //    {
    //        Debug.LogError(args.DatabaseError.Message);
    //        return;
    //    }

    //}


    //// Use this for initialization
    //void Start()
    //{
    //    FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://storybox-hackmit.firebaseio.com/");
    //    Firebase.Database.DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    FirebaseDatabase.DefaultInstance
    //    .GetReference("Leaders").ValueChanged += HandleValueChanged;
    //}
}
