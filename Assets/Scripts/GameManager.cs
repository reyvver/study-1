using DefaultNamespace;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public UIManager ui;
	public int offsetX = -15;
	public Transform spawnPoint;
	public GameObject player;

	private float elapsedTime = 0;
	private bool isRunning = false;
	private bool isFinished = false;

	private FirstPersonController fpsController;
	
	void Start ()
	{
		fpsController = player.GetComponent<FirstPersonController> ();
		StartGame();
	}

	private void StartGame()
	{
		elapsedTime = 0;
		isRunning = true;
		isFinished = false;

		PositionPlayer();
	}

	void Update ()
	{
		if (isRunning)
		{
			elapsedTime = elapsedTime + Time.deltaTime;
			ui.UpdateTime((int)elapsedTime);
		}

		if (Input.GetKey("escape"))
		{
			Application.Quit();
		}
	}

	public void PositionPlayer()
	{
		player.transform.position = spawnPoint.position;
		player.transform.rotation = spawnPoint.rotation;
	}

	public void FinishedGame()
	{
		isRunning = false;
		isFinished = true;
		fpsController.enabled = false;
	}

	public void ReloadScene()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void Finish()
	{
		FinishedGame();
		ui.ShowFinishPanel();
	}
}
