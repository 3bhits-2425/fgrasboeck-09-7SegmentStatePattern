// Represents 1 digit for a 7 segment display
public class State1 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 1;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State2();
    }

    public ISevenSegmentDisplayState CountDown() {
        return  State0.GetState();
    }


}
