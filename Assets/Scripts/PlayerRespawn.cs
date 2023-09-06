using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
	public GameManager gameManager;

	void OnTriggerEnter(Collider other)
	{
		gameManager.ReloadScene();
	}
}
