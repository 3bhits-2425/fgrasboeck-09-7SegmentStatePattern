// Represents 0 digit for a 7 segment display
public class State6 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 6;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State7();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State5();
    }


}
