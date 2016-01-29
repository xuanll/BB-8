using UnityEngine;
using System.Collections;

public class HeadMovement : MonoBehaviour {

    [SerializeField]
    private Transform _bodyTransform;
    private Transform _headTransform;
    [SerializeField]
    private float distanceFromBody = 0.65f;
    private SpriteRenderer _headSprite;
    private float _lastPosX;

	//add head Sprites
	[SerializeField]
	private Sprite headLeft;
	[SerializeField]
	private Sprite headRight;

    void Start()
    {
        _headTransform = GetComponent<Transform>();
        _headSprite = GetComponent<SpriteRenderer>();
        _lastPosX = _bodyTransform.position.x;
    }

    void FixedUpdate()
    {
        _headTransform.position = Vector2.Lerp(_headTransform.position, new Vector2(_bodyTransform.position.x, _bodyTransform.position.y + distanceFromBody), 0.35f);
        _headTransform.rotation = Quaternion.Lerp(_headTransform.rotation, Quaternion.Euler(0, 0, 0), 0.35f);
        if ((_bodyTransform.position.x - _lastPosX) > 0.01f)
        {
			//Sprite Render flip not support in Unity5.1.4f Personal
			//use multiple Sprite image instead
//            _headSprite.flipX = true;
			_headSprite.sprite = headRight;
        }
        else if ((_bodyTransform.position.x - _lastPosX) < -0.01f)
        {
//            _headSprite.flipX = false;
			_headSprite.sprite = headLeft;
        }
        _lastPosX = _bodyTransform.position.x;
    }
}
