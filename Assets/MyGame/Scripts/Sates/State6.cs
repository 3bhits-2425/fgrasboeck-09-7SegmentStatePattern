// Represents 0 digit for a 7 segment display
public class State6 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;

    private State6()
    {

    }
    
    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State6();
        }

        return _state;
    }

    public int GetDigit() {
        return 6;

    }

    public ISevenSegmentDisplayState CountUp() {
        return State7.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return State5.GetState();
    }


}
