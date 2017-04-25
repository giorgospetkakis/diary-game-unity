using UnityEngine;

public class CutsceneMngr : MonoBehaviour {

    public GameObject[] backdrops;
    public GameObject currBackdrop;

    public void LoadBackdrop(int num){
        if(backdrops[num])
            currBackdrop = backdrops[num];

        currBackdrop = Instantiate(currBackdrop) as GameObject;
    }

    public void DespawnBackdrop(){
        Destroy(currBackdrop);
    }
}