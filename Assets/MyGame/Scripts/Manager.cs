using System.Text;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private SevenSegmentDisplay myDigit;
    private UIManager myUIManager;

    private const int MinDigit = 0;
    private const int MaxDigit = 9;

    private ISevenSegmentDisplayState myDisplayState;

    private void Start()
    {
        myDisplayState = State0.GetState();

        if(myDigit == null)
        {
            Debug.LogWarning($"In Component `{GetType().Name}` attached to GameObject `{gameObject.name}`, " +
                             $"the object `{nameof(myUIManager)}` was not assigned in the inspector!", this);
            return;
        }

        myUIManager = GetComponent<UIManager>();
        
        if (myUIManager == null)
        {
            Debug.LogWarning($"In Component `{GetType().Name}` attached to GameObject `{gameObject.name}`, " +
                             $"the object `{nameof(myUIManager)}` was not assigned in the script!", this);
            return;
        }

        myUIManager.SetDisplay(myDigit);
        myDigit.ResetSegmentDisplay();
    }

    private void Update() {
        if (myDigit == null) return;
        if (!myDigit.isActive) return;
        //if (myDigit.isNumberSet) return;
        //Debug.Log("Tesrt");
       

        //for (int i = MinDigit; i <= MaxDigit; i++)
        //{
        //    if (IsDigitPressed(i))
        //    {
        //        HandleDigitInput(i);
        //        break;
        //    }
        //}

        if (IsPlusPressed()) {
            myDisplayState = myDisplayState.CountUp();
        }
        if (IsMinusPressed()) {
            myDisplayState = myDisplayState.CountDown();
        }
        HandleDigitInput(myDisplayState.GetDigit());
    }

    private void HandleDigitInput(int digit)
    {
        myDigit.isNumberSet = true;

        myDigit.ExtendSegmentsFor(digit);
        myUIManager.DeactivateInstruction();
        myUIManager.ActivateResetBtn(true);
    }
    
    private bool IsPlusPressed() {
        return Input.GetKeyDown(KeyCode.Y) ||
               Input.GetKeyDown(KeyCode.KeypadPlus);
    }

    private bool IsMinusPressed() {
        return Input.GetKeyDown(KeyCode.Z) ||
               Input.GetKeyDown(KeyCode.KeypadMinus);
    }

    private bool IsDigitPressed(int i)
    {
        return Input.GetKeyDown((KeyCode)((int)KeyCode.Alpha0 + i)) ||
                        Input.GetKeyDown((KeyCode)((int)KeyCode.Keypad0 + i));
    }
}
