using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

static public class Settings
{
    static float calcCounter;

    public static float GetMaxDifficulty()
    {
        //return 1;
        calcCounter = Spawner.counter;
        return Mathf.Clamp01(calcCounter/10);
        
    }
    
}
