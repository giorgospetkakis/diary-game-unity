using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichIngredientAccept : MonoBehaviour {

	public int ingredientCount;

	// Use this for initialization
	public void incrementIngredientCount(){
		ingredientCount++;
		Debug.Log("Ingredient Count:" + ingredientCount);
	}
}
