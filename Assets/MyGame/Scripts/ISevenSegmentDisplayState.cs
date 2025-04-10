public interface ISevenSegmentDisplayState {
    public int GetDigit();  //Get number of current state
    public ISevenSegmentDisplayState CountDown(); //Switch to previous state
    public ISevenSegmentDisplayState CountUp(); //Switch to next state

}