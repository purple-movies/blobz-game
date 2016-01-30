using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Food : BlobBody
{
    public bool canEat = false;

    protected override void onStart()
    {
        base.onStart();
        diameter = .25f;
        //diameter = 1f;
        graphic.GetComponent<Renderer>().sharedMaterial.color 
            = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
