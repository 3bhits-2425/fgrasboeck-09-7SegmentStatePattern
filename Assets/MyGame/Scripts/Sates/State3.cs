// Represents 3 digit for a 7 segment display
public class State3 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 3;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State4();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State2();
    }


}
