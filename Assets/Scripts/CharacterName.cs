using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class CharacterName : MonoBehaviour
{
	[SerializeField] InputField NameField;
	[SerializeField] Character Character;
	[SerializeField] Canvas SecondCanvas;
	[SerializeField] Flowchart flowchart;

	public static string Name = "Morty";



	public void SetName()
	{
		if (NameField.text.Length != 0)
		{
			Name = NameField.text;
			Character.NameText = Name;
		}	
		
		flowchart.SetStringVariable("name", Name);
		SecondCanvas.gameObject.SetActive(false);
		Debug.Log($"{CharacterName.Name}");
		
	}
}
