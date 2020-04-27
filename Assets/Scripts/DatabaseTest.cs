using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DatabaseTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Count
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log(DatabaseEssential.DatabaseManager.instance.Count("member"));
        }
        //Select
        if (Input.GetKeyDown(KeyCode.S))
        {
            string columnName = "ID,Username,Password,Email,Phone,Address";
            List<string>[] results = DatabaseEssential.DatabaseManager.instance.SelectAllRecord("userdata",columnName);

            for (int i = 0; i < results.Length; i++)
            {
                List<string> tempList = results[i];
                foreach (var records in tempList)
                    Debug.Log(records);
            }
        }
        //Update
        if(Input.GetKeyDown(KeyCode.U))
        {
            DatabaseEssential.DatabaseManager.instance.UpdateRecord("userdata", "Username='Ashikur Rahman' WHERE Username='Srejon Khan'");
            Debug.Log("Update DONE");
        }
        //Insert
        if (Input.GetKeyDown(KeyCode.I))
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new System.Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            var randomName = new String(stringChars);
            
            DatabaseEssential.DatabaseManager.instance.InsertRecord("userdata", "ID,Username,Password,Email,Phone,Address", $"'0', '{randomName}', '123456', '{randomName}@gmail.com', '0123456789', 'Unknown Street, Unknown Street'");
            Debug.Log("Insert Done");
        }
        //Delete
        if (Input.GetKeyDown(KeyCode.D))
        {
            DatabaseEssential.DatabaseManager.instance.DeleteRecord("userdata", "Username='Ashikur Rahman'");
            Debug.Log("Delete Done");
        }
        //Select Certain
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log(DatabaseEssential.DatabaseManager.instance.Query("SELECT * FROM userdata ORDER BY ID DESC"));       
        }
    }
}
