using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.Experimental.UIElements;

public class POINT_SYSTEM : MonoBehaviour
{

//points
    public float _points;
    private bool _trigger_flag = false;
    public float _point_per_second = 1; // point gain/loss per second
    private float _point_frame_multiplier = 0.01f; // gain per second defined in one frame

//text
    public TextMeshProUGUI countText;
    //public UIElements.Image _game_over_screen;
    public GameObject _game_over_screen;


    //triggers
    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("trigger_sphere")==true)
        {
            _trigger_flag = true;
            //_points = _points-10;
            //SetCountText();
        }//else {_trigger_flag = false;}
        
    }

    private void OnTriggerExit(Collider other){
        //if (other.CompareTag("trigger_sphere")==true)
        //{
            _trigger_flag = false;
            //Debug.Log("EXIT");
        //}
    }


    //text handling
    void SetCountText()
	{
        var disp_points = 100.0f - _points;
		countText.text = disp_points.ToString("0.");
	}

    // Start is called before the first frame update
    void Start()
    {
        _points = 100.0f;
        SetCountText();
        _game_over_screen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(_trigger_flag == true){
            _points = _points - _point_frame_multiplier*_point_per_second;
            if(_points < 0){
                _points = 0;
                _game_over_screen.SetActive(true);
            }
            SetCountText();
            
        }
        //Debug.Log(_trigger_flag);
        //Debug.Log(_points);
    }
}
