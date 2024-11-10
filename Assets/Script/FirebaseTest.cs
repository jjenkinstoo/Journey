using UnityEngine;

using Firebase;
using Firebase.Database;
using Firebase.Extensions;

//using Firebase.Extensions.TaskExtension; // for ContinueWithOnMainThread

public class FirebaseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FirebaseDatabase reference = FirebaseDatabase.GetInstance("https://journey-xx-default-rtdb.firebaseio.com/");
        
        // reference.GetReference("Test").GetValueAsync().ContinueWithOnMainThread(task =>
        // {
        //     if (task.IsFaulted)
        //     {
        //         // Handle the error...
        //         Debug.Log("Faulted");
        //     }
        //     else if (task.IsCompleted)
        //     {
        //         DataSnapshot snapshot = task.Result;
        //         // Do something with snapshot...
        //         Debug.Log(snapshot.GetRawJsonValue());
        //     }
        // });
        //
        
        reference.GetReference("Players").SetRawJsonValueAsync("{\"John Doe\": \"Tank\"}");
        reference.GetReference("Players").ValueChanged += this.HandleValueChanged;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    
    void HandleValueChanged(object sender, ValueChangedEventArgs args) {
        if (args.DatabaseError != null) {
            Debug.LogError(args.DatabaseError.Message);
            return;
        }
        // Do something with the data in args.Snapshot
        Debug.Log(args.Snapshot.GetRawJsonValue());
    }
}
