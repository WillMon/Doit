using UnityEngine;
using System.Collections.Generic;

public delegate void Del(string s);
public class Delegate : MonoBehaviour
{
    void DelegateMethod(string input)
    {
        print(input);
    
   }
    void DelegateMethod2(string Yes)
    {
        print(Yes + "I am a dif Function ");

    }
    

    [ContextMenu("delegates")]
	// Use this for initialization
	void Start () {
        Del d = DelegateMethod;
        d += DelegateMethod2;
        d("Hello");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
