using UnityEngine;
using System.Collections.Generic;


public class Doit : MonoBehaviour
{
    GameObject Get;
    [ContextMenu("Testing STuff Out")]
    public List<Transform> Childs = new List<Transform>();
    void Player()
    {
        Debug.Log(GetInstanceID());
        Get = GameObject.FindGameObjectWithTag("Player");
        foreach(Transform T in Get.transform)
        {
            Childs.Add(T);
        }
        foreach(Transform P in Childs)
        {
            print(P);
        }
    }

    
	// Use this for initialization
	void Start () {
        
	}   
	
	// Update is called once per frame
	void Update () {
	
	}
}
