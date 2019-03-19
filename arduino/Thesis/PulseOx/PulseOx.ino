//PulseOx
const int numReadings = 5;
int readings[numReadings];      // the readings from the analog input
int readIndex = 0;              // the index of the current reading
int total = 0;                  // the running total
int average = 0;                // the average

int Pulse = A0;

void setup() {
  Serial.begin(9600);
    for (int thisReading = 0; thisReading < numReadings; thisReading++)
    {
    readings[thisReading] = 0;
    }
}
void loop() 
{
  while (digitalRead(Pulse) == HIGH);
  while (digitalRead(Pulse) == LOW);
  int T1 = millis();
  while (digitalRead(Pulse) == HIGH);
  while (digitalRead(Pulse) == LOW);
  int T2 = millis();
  int Time = T2-T1;
  unsigned long HeartRate = 60000L;
  HeartRate = HeartRate/Time; 

  //smoothing
  total = total - readings[readIndex];
  readings[readIndex] = HeartRate;
  total = total + readings[readIndex];
  readIndex = readIndex + 1;
  
  int x = 0;
  x = readIndex % 5;
  if (x == 0) 
  {
  Serial.print(" BPM: ");
  Serial.print(HeartRate);
  }
  if (readIndex >= numReadings) 
  {
  readIndex = 0;  
  average = total / numReadings;
  int OxygenSat = map(average, 67, 100, 97, 80);
  Serial.print(" Oxygen Saturation: ");
  Serial.print(OxygenSat);
  Serial.print("% & Average BPM = ");
  Serial.println(average);
  }
  delay(1);
} 
