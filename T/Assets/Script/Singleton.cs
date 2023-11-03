using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T:MonoBehaviour
{
    public static T instance;
    public bool _isDontDestroyOnLoad = false;

    protected virtual void Awake()
    {
        if(!instance)
        {
            instance = GetComponent<T>();
            if (_isDontDestroyOnLoad)
            {
                DontDestroyOnLoad(instance);
            }
        }
        else if(instance != this) {
            Destroy(gameObject);
        }
    }
}
