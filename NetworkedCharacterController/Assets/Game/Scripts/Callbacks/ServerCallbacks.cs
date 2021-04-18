using UnityEngine;

[BoltGlobalBehaviour(BoltNetworkModes.Server, "MainLevel")]
public class ServerCallbacks : Bolt.GlobalEventListener {
    public override void SceneLoadLocalDone(string map) {
        BoltNetwork.Instantiate(BoltPrefabs.MainPlayer);
    }

    public override void SceneLoadRemoteDone(BoltConnection connection) {
        BoltNetwork.Instantiate(BoltPrefabs.MainPlayer);
    }
}