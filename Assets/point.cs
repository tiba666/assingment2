using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class point : MonoBehaviour
{

	private int count = 0;
	public Text countText;
	public string newGameLevel;
	// Start is called before the first frame update
	void Start()
	{
		setCountText();

	}


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("point"))
		{
			other.gameObject.SetActive(false);
			count += 1;
			print(count);
			setCountText();
		}
	}
	void setCountText()
	{
		countText.text = "Count: " + count.ToString();
		if (count == 3)
		{
			SceneManager.LoadScene(newGameLevel);
		}
	}
}
