using Bolt.AdvancedTutorial;

[BoltGlobalBehaviour("MainLevel")]
public class PlayerCallbacks : Bolt.GlobalEventListener {
    public override void SceneLoadLocalDone(string map) {
        PlayerCamera.Instantiate();
    }

    public override void ControlOfEntityGained(BoltEntity entity) {
        // this tells the player camera to look at the entity we are controlling
        PlayerCamera.instance.SetTarget(entity);
    }
}