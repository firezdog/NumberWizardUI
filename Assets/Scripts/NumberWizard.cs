using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {

	[SerializeField] TMP_Text guessText;
	[SerializeField] int max;
	[SerializeField] int min;
	int guess;
	public System.Random ayn = new System.Random();

	void Start ()
	{
		guess = ayn.Next(min, max);
		nextGuess(guess);		
	}

	public void Higher() {
		min = guess + 1;
		NextGuess();
	}

	public void Lower() {
		max = guess - 1;
		NextGuess();
	}

	void nextGuess(int guess) {
		guessText.text = guess.ToString();		
	}

	void NextGuess()
	{
		guess = min + (max - min)/2;
		guessText.text = guess.ToString();
	}

}
