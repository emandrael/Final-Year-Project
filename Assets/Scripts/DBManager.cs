using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleSQL;
using Scriptable_Object_Scripts;

public class DBManager : MonoBehaviour
{
    [SerializeField] private SimpleSQLManager SimpleSQLManager;
    // Start is called before the first frame update
    void Start()
    {
        SimpleSQLManager = GetComponent<SimpleSQLManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
