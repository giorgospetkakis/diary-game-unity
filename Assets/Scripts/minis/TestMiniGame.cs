using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMiniGame : MiniGame{
    
    // Public functions called by MiniGameMngr
    public override void init() {

    }
    public override void begin() {
        Debug.Log("This game has now begun");
    }

    public static void dummy() {
        
    }
}