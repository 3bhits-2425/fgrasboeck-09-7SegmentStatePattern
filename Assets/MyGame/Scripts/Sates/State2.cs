// Represents 2 digit for a 7 segment display
public class State2 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 2;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State3();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State1();
    }


}
