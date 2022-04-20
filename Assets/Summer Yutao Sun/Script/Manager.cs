using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager
{
    private static Manager Instance;
    public static Manager instance
    {
        get
        {
            if (Instance==null)
            {
                Instance = new Manager();
            }
            return Instance;
        }
    }

    public int number;
    public float Speed = 5f;
    public bool timeoff = true;
}
