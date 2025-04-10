// Represents 2 digit for a 7 segment display
public class State2 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private State2()
    {

    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State2();
        }

        return _state;
    }
    public int GetDigit() {
        return 2;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State3.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State1.GetState();
    }


}
