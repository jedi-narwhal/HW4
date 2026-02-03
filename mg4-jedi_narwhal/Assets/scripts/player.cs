using System.Collections;

using UnityEngine;

public class player : MonoBehaviour
{
  
    [SerializeField] private gamecontroller _gameController;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jump;
    [SerializeField] private AudioSource _audioSource;
     [SerializeField] private AudioClip _audioflying;
    private bool _gameover;
       private bool _isGrounded;


   public delegate void Delegate();
    public event Delegate EndGame;



    void Start()
    {
        _gameover=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _gameover==false)
            {
                Debug.Log("if");
                _rigidbody.velocity = new Vector2(
                _rigidbody.velocity.x,
                _jump);   
                Debug.Log("jump");       
                 _audioSource.clip=_audioflying;
                _audioSource.Play();
            }
    
    }
     
     private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "point" && _gameover==false)
        {
            _gameController.AddPoints();
        }


  
    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "pipe")
        {
            _gameover=true;
            EndGame?.Invoke();
            Destroy(collision.gameObject);
        }

    }




}
