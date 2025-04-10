// Represents 8 digit for a 7 segment display
public class State8 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State8()
    {

    }
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State8();
        }

        return _state;
    }

    public int GetDigit() {
        return 8;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State9.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State7.GetState();
    }


}
