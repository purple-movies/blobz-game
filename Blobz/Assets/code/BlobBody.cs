using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BlobBody : MonoBehaviour
{
    [SerializeField] protected GameObject graphic;
    float mDiameter;
    //Rigidbody2D body;
    new CircleCollider2D collider;
    protected float moveSpeed = 4;

    protected virtual void onStart()
    {
        //body = GetComponent<Rigidbody2D>();
        collider = GetComponent<CircleCollider2D>();
        diameter = 1;
    }

    public virtual float diameter
    {
        get { return mDiameter; }
        set
        {
            mDiameter = value;
            collider.radius = value * .5f;
            graphic.transform.localScale = new Vector3(value, value, value);
        }
    }

    void Start() { onStart(); }
}
