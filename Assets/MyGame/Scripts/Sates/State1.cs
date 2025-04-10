// Represents 1 digit for a 7 segment display
public class State1 : ISevenSegmentDisplayState
{
    private static ISevenSegmentDisplayState _state;
    private State1()
    {

    }

    public static ISevenSegmentDisplayState GetState()
    {
        if (_state == null)
        {
            _state = new State1();
        }

        return _state;
    }

        public int GetDigit() {
        return 1;
    }

    public ISevenSegmentDisplayState CountUp() {
        return State2.GetState();
    }

    public ISevenSegmentDisplayState CountDown() {
        return  State0.GetState();
    }


}
