// Represents 0 digit for a 7 segment display
public class State7 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 7;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State8();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State6();
    }


}
