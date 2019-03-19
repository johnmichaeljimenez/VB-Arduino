//LIBRARIES:
//Height N/A
//Weight
#include "HX711.h"
//Pulse N/A
//Temperature
#include <Wire.h>
#include "Adafruit_MLX90614.h"
//PINS:
//Height
const int trigPin = 9;
const int echoPin = 10;
//Weight
const int LOADCELL_DOUT_PIN = 2;
const int LOADCELL_SCK_PIN = 3;
//Pulse
int Pulse = A0;
//Temperature N/A
//VARIABLE:
//Height
long duration;
int distance;
//Weight
HX711 scale;
//Pulse
const int numReadings = 25;
int readings[numReadings];      // the readings from the analog input
int readIndex = 0;              // the index of the current reading
int total = 0;                  // the running total
int average = 0;                // the average
//Temperature
Adafruit_MLX90614 mlx = Adafruit_MLX90614();
void setup() 
{
  //Height
  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT); // Sets the echoPin as an Input
  //Weight
  scale.begin(LOADCELL_DOUT_PIN, LOADCELL_SCK_PIN);
  //Pulse
  for (int thisReading = 0; thisReading < numReadings; thisReading++)
  {
  readings[thisReading] = 0;
  }
  //Temperature
  mlx.begin(); 
  Serial.begin(9600);
  Serial.println("Choose between numbers 1 to 4 to select measurement");
}
void loop() 
{
  //General
  if (Serial.available())
  {
    char ch = Serial.read();
    if (ch == 1) //Height
    {
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);
    // Sets the trigPin on HIGH state for 10 micro seconds
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
    // Reads the echoPin, returns the sound wave travel time in microseconds
    duration = pulseIn(echoPin, HIGH);
    // Calculating the distance
    distance= duration*0.034/2;
    // Prints the distance on the Serial Monitor
    while (distance == 0)
      {
        Serial.print("Distance: ");
        Serial.println(1879.6-distance);
        delay(1000);
      }
    }
    if (ch == 2) //Weight
    {
      if (scale.is_ready())
      {
        long reading = scale.read();
        Serial.print("HX711 reading: ");
        Serial.println(reading);
      } 
      else 
      {
        Serial.println("HX711 not found.");
      }
    delay(1000);
    }
    if (ch == 3) //Pulse
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
    if (ch == 4) //Temperature
    {
      Serial.print("Ambient = "); Serial.print(mlx.readAmbientTempC()); 
      Serial.print("*C\tObject = "); Serial.print(mlx.readObjectTempC()); Serial.println("*C");
      Serial.print("Ambient = "); Serial.print(mlx.readAmbientTempF()); 
      Serial.print("*F\tObject = "); Serial.print(mlx.readObjectTempF()); Serial.println("*F");
      Serial.println();
    delay(500);
    }
    else
    {
    Serial.println("Invalid");
    }
  }
}
