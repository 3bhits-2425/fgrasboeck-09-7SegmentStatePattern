// Represents 0 digit for a 7 segment display
public class State4 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 4;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State5();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State3();
    }


}
