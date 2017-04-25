using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandwichIngredientAccept : MonoBehaviour {

	public int breadCount, sThresh;
	public int sandwichCount;
	public GameObject GameManager;
	ArrayList ingredientStack;


	void Start() {
		GameManager = GameObject.Find("GameManager");
		ingredientStack = new ArrayList();
		sThresh = 2;
	}

	public void addIngredientToStack(GameObject ing){
		ing.GetComponent<Collider2D>().enabled = false;
		GameObject temp = Instantiate(ing, gameObject.transform.position, Quaternion.Euler(0,0,Random.Range(-30, 30))) as GameObject;
		ingredientStack.Add(temp);
		if(ing.tag == "Bread")
			breadCount++;

		if(breadCount == 2) {
			foreach(GameObject i in ingredientStack) {
				Destroy(i);
			}
			breadCount = 0;
			sandwichCount++;
		}
		
		if(sandwichCount > sThresh) {
			GameManager.GetComponent<EventQueue>().runLineQueueMini();
			sThresh++;
		}
	}
}
