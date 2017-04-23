using UnityEngine;

public class DragIngredients : MonoBehaviour {

    GameObject extra;
    public GameObject Mini;
    public BoxCollider2D SandwichMakeArea, SandwichDropArea;

    void OnMouseDrag() {
        if(!extra) {
            extra = Instantiate(gameObject, transform.position, Quaternion.identity) as GameObject;
            extra.transform.parent = Mini.transform;
        }
        GetComponent<SpriteRenderer>().color = new Color(0.9f,0.9f,0.9f);
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                extra.transform.position = hit.point;
            }
    }

    void OnMouseUp() {
        Destroy(extra);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    void OnTriggerEnter2D() {
        
    }
}
