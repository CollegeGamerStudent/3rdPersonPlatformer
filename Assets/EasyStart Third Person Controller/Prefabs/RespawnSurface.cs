using UnityEngine;

public class RespawnSurface : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController controller = other.GetComponent<CharacterController>();
            if (controller != null)
            {
                // Disable controller temporarily to avoid collision issues
                controller.enabled = false;

                // Move player to respawn point
                Vector3 respawnPos = CheckpointManager.Instance.GetRespawnPosition();
                other.transform.position = respawnPos;

                // Re-enable controller
                controller.enabled = true;
            }
        }
    }
}