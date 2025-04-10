// Represents 8 digit for a 7 segment display
public class State8 : ISevenSegmentDisplayState
{

    public int GetDigit() {
        return 8;
    }

    public ISevenSegmentDisplayState CountUp() {
        return new State9();
    }

    public ISevenSegmentDisplayState CountDown() {
        return new State7();
    }


}
