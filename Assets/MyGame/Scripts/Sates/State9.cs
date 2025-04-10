// Represents 9 digit for a 7 segment display
public class State9 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State9()
    {

    }
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State9();
        }

        return _state;
    }

    public int GetDigit() {
        return 9;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State0.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State8.GetState();
    }


}
