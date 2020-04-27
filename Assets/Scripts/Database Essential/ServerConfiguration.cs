using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DatabaseEssential
{
    [CreateAssetMenu(fileName = "ServerConfig", menuName = "Database/Server Configuration", order = 0)]
    public class ServerConfiguration : ScriptableObject
    {
        public string host, port, database, user, password;
    }
}
