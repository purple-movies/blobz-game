using UnityEngine;
using System.Collections;

public class PlayerBehaviour : BlobBody
{
    //public override float diameter
    //{
    //    get { return base.diameter; }
    //    set
    //    {
    //        graphic.transform.localScale = new Vector3(value, value, value);
    //        base.diameter = value;
    //    }
    //}

    public void OnTriggerStay2D(Collider2D collision)
    {
        var collisionGameObject = collision.gameObject;
        if (collisionGameObject.layer == 8)
        {
            GameObject.Destroy(collisionGameObject);
            diameter += .05f;
        }
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        transform.position = Vector3.MoveTowards(transform.position, mousePos, moveSpeed * Time.deltaTime);
    }
}
