using UnityEngine;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour
{
    [SerializeField]
    Behaviour[] componentsToDisable;

    Camera sceneCamera;

    // Start is called before the first frame update
    void Start()
    {
        ShootObjects.justShot = false;
        if (!isLocalPlayer) {
            // Disable player movement and camera components
            for (int i = 0; i < componentsToDisable.Length; i++) {
                componentsToDisable[i].enabled = false;
            }
        } else {
            sceneCamera = Camera.main;

            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }
    }

    private void OnDestroy() {
        if (sceneCamera != null)
            sceneCamera.gameObject.SetActive(true);
    }
}
