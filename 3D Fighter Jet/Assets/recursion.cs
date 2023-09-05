using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recursion : MonoBehaviour
{
    public int[] arr;
    float time;
    public void Start()
    {
        arr = new int[100000000];
        for(int i= 0; i < arr.Length; i++)
        {

        }
        StartCoroutine(check());
        
    }
    IEnumerator check()
    {
        yield return new WaitUntil(predicate: ()=> arr.Length == 100000000);
        Debug.Log(Time.time);
    }

}
