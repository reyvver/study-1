using UnityEngine;

public class FinishZone : MonoBehaviour
{
	public GameManager gameManager;
	void OnTriggerEnter(Collider other)
	{
		gameManager.FinishedGame();
	}
}
