using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// SCRIPT TO HANDLE THE RESTART BUTTON //
// SCRIPT TO HANDLE THE RESTART BUTTON //
// SCRIPT TO HANDLE THE RESTART BUTTON //
// SCRIPT TO HANDLE THE RESTART BUTTON //

public class RestartButton : MonoBehaviour
{
	private void Start()
	{
		
		// Assuming the button has an onClick event set up in the Unity Editor,
		Button button = GetComponent<Button>();
		// will assign the RestartGame method to the onClick event
		button.onClick.AddListener(RestartGame);
	}
// method to restart the game
	private void RestartGame()
	{
		// Add your game restart logic here, for example:
		// will load the same scene as the current one if the button is clicked and will reset the time scale to 1 if the button is clicked
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		Time.timeScale = 1;
	}
}
