// Represents 3 digit for a 7 segment display
public class State3 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private State3()
    {

    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State3();
        }

        return _state;
    }

    public int GetDigit() {
        return 3;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State4.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State2.GetState();
    }


}
