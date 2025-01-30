using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class BearMovement : MonoBehaviour
{
  public static BearMovement instance;

  public  CharacterController _characterController;
  [SerializeField] private float speed;
  private Vector3 _movement;
  private Camera cam;
  [SerializeField] float rotationSmoothTime; 
  float currentAngle; 
  float currentAngleVelocity;

  public Vector3 movement
  {
    get => _movement;

  }

  private void Start()
  {
    instance = this;
    _characterController = GetComponent<CharacterController>();
    cam = Camera.main;
  }

  private void Update()
  {
    TakeInput();  
    HandleMovement();
  }

  public void TakeInput()
  {
    _movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
  }
  private void HandleMovement()
  {
    Debug.Log(_characterController.velocity);
   
    if (movement.magnitude >= 0.1f)
    {
      
      float targetAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg + cam.transform.eulerAngles.y;
      currentAngle = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref currentAngleVelocity, rotationSmoothTime);
      transform.rotation = Quaternion.Euler(0, currentAngle, 0);
      Vector3 rotatedMovement = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
      _characterController.Move(rotatedMovement * speed * Time.deltaTime);
      
    }
  }
    
   
  }
  

