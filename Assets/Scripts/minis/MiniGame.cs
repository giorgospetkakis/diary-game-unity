using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MiniGame : MonoBehaviour{
    
    // Public functions called by MiniGameMngr
    public abstract void init();
    public abstract void begin();
}