using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class Homework : MonoBehaviour
{
    public string firstName;
    public string lastName;
    public string fullName;
    public string[] names;
    

    private Camera cam;
}

void Start()
{
    names = new string[2];

    names[0] = "Kikey";
    names[1] = "Guan";

    fullName = GetFullName(names[0], names[1]);

    CheckpointA();

}


public void CheckpointA()
{

    if (GetSumOf(5,6) > GetProductOf(GetSumOf(5, 6), 1))
    {
        CheckpointB(false);

    }

}

public void CheckpointB(bool status)
{
    if (status = true) 
    {
        if (cam == Camera.main)
        {
            CheckpointC();   
        }
    }
}
    

public void CheckpointC()
{
    if (names[3]  == lastName)
    {
        OnMessage();
    }
}

public int GetSumOf(int a, int b)
{
    return a + b;
}

public float GetProductOf(float a, float b)
{
    return a * b;
}


public string GetFullName(string first, float last)
{
    return first + last;
}

    /// You do not need to make and changes or fixes to the code below. 
    /// You should read the code, but you don't need to make any changes below this line to complete the assignment  <summary>
    /// You do not need to make and changes or fixes to the code below. 

private void OnMessage()
    {
        Debug.Log(fullName + " completed the " + this.GetType().Name + " at: " + Date().ToString());
    }

private System.DateTime Date()
    {
        return System.DateTime.Now;
    }


