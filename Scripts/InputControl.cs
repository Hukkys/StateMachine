using UnityEngine;


public class InputControl : MonoBehaviour
{
    private float axisHorizontalMove;
    public float AxisHorizontalMove => axisHorizontalMove;


    private float axisMouseScroll;
    public float AxisMouseScroll => axisMouseScroll;


    private bool jump;
    public bool Jump => jump;


    private bool sitDown;
    public bool SitDown => sitDown;


    private bool use;
    public bool Use => use;


    private bool info;
    public bool Info => info;


    private bool attack;
    public bool Attack => attack;


    private bool run;
    public bool Run => run;



    void Update()
    {
        axisHorizontalMove = Input.GetAxis("Horizontal");

        axisMouseScroll = Input.GetAxis("Mouse ScrollWheel");

        jump = Input.GetKey(KeyCode.Space);

        sitDown = Input.GetKey(KeyCode.LeftControl);

        use = Input.GetKey(KeyCode.E);

        info = Input.GetKey(KeyCode.Tab);

        attack = Input.GetMouseButton(0);

        if (axisHorizontalMove != 0 & Input.GetKey(KeyCode.LeftShift)) run = true; else run = false;

    }
}
