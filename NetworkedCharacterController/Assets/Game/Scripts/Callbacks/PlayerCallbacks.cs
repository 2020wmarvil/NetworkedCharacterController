using Bolt.AdvancedTutorial;

[BoltGlobalBehaviour("MainLevel")]
public class PlayerCallbacks : Bolt.GlobalEventListener {
    public override void SceneLoadLocalDone(string map) {
        PlayerCamera.Instantiate();
    }
}