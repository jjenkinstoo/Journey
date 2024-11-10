using Firebase;
using Firebase.Database;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        var a = FirebaseDatabase.GetInstance("https://journey-xx-default-rtdb.firebaseio.com/");
        a.GetReference("Test2").SetRawJsonValueAsync("{ \"name\": \"John Did\"}");
        a.GetReference("Hyungjin").SetValueAsync("Is cool");
        a.RootReference.Child("HyungjinIsCool").SetRawJsonValueAsync("He sure is.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}