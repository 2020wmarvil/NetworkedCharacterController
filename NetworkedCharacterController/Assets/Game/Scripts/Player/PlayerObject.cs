using UnityEngine;

public class TutorialPlayerObject {
    public BoltEntity character;
    public BoltConnection connection;

    public bool IsServer {
        get { return connection == null; }
    }

    public bool IsClient {
        get { return connection != null; }
    }
}