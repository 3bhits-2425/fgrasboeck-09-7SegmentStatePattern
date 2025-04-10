// Represents 0 digit for a 7 segment display
public class State0 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State0()
    {

    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State0();
        }
       
        return _state;


    }


    public int GetDigit() {
        return 0;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State1.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State9.GetState();
    }


}
