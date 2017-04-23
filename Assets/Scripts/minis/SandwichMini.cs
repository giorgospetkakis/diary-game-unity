using UnityEngine;

public class SandwichMini : MiniGame {

    public Sprite[] Ingredients;
    public GameObject[] IngredientSpawnPoints;

    public override void init(){

    }

    public override void begin() {
        for (int i = 0; i < Ingredients.Length; i++) {
            IngredientSpawnPoints[i].GetComponent<SpriteRenderer>().sprite = Ingredients[i];
        }
    }
}
