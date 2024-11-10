using UnityEngine;

using Firebase;
using Firebase.Database;
//using Firebase.Extensions.TaskExtension; // for ContinueWithOnMainThread

public class FirebaseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
