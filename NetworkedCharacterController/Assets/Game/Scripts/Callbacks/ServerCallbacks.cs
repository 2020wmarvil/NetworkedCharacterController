using UnityEngine;

[BoltGlobalBehaviour(BoltNetworkModes.Server, "MainLevel")]
public class ServerCallbacks : Bolt.GlobalEventListener {
	void Awake() {
        PlayerObjectRegistry.CreateServerPlayer();
    }

    public override void Connected(BoltConnection connection) {
        PlayerObjectRegistry.CreateClientPlayer(connection);
    }

    public override void SceneLoadLocalDone(string map) { 
        PlayerObjectRegistry.ServerPlayer.Spawn();
    }

    public override void SceneLoadRemoteDone(BoltConnection connection) { 
        PlayerObjectRegistry.GetPlayer(connection).Spawn();
    }
}