#include <Servo.h>

int sensorPin = A0;    // select the input pin for the potentiometer
int ledPin = 13;      // select the pin for the LED
int sensorValue = 0;  // variable to store the value coming from the sensor
const int trigPin = 8;
const int echoPin = 7;
int servo = 8;
bool bookingActive = false;
bool occupying = false;
bool doneOccupying = false;
bool unoccupying = false;
bool doneUnoccupying = false;

#include <ArduinoJson.h>
#define DEVICE_INFO "{\"name\":\"Metroparking Manager\",\"version\":\"v1.2\",\"id\":\"WNsMSj5kJ0GhAs40pILnmTsjfkKvQO5C\"}" // Device info of the device

Servo myservo;

void setup() {
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
  pinMode(trigPin, OUTPUT); // Sets the trigPin as an Output
  pinMode(echoPin, INPUT); // Sets the echoPin as an Input
  pinMode(12, OUTPUT);
  pinMode(11, OUTPUT);
  myservo.attach(9);
  myservo.write(100);
}

void loop() {
  if (Serial.available() > 0) {
    commandRecieved();
  }
  checkVehicle();
  if (bookingActive) {
    digitalWrite(12, HIGH);
    digitalWrite(11, LOW);
  } else {
    digitalWrite(12, LOW);
    digitalWrite(11, HIGH);
  }
  //Serial.println((String)senseDistance());
}

void commandRecieved() {
  // Function to parse recieved commands
  // Accepts _data as String and return null
  // TO BE CODED----------------------------
  //
  String command = Serial.readStringUntil(':');
  String data = Serial.readStringUntil('\n');

  if (command.equals("occupy")) {
    
    if (data.equals("true")) {
      if (doneOccupying) {
        digitalWrite(ledPin, LOW);
        sendUpdate();
        occupying = false;
        doneOccupying = false;
      } else {
        digitalWrite(ledPin, HIGH);
        myservo.write(200);
        occupying = true;
        sendUpdate();
      }
    } else if (data.equals("false")) {
      if (doneUnoccupying) {
        digitalWrite(ledPin, LOW);
        sendUpdate();
        unoccupying = false;
        doneUnoccupying = false;
      } else {
        digitalWrite(ledPin, HIGH);
        myservo.write(200);
        unoccupying = true;
        sendUpdate();
      }
    } else {
      sendUpdate();
    }
  } else if (command.equals("deviceInfo")) {
    Serial.print("deviceInfo:");
    Serial.println(DEVICE_INFO);
  } else if (command.equals("update")) {
    sendUpdate();
  }
}

void sendUpdate() {
  // Serialized the sensor data as JSON and sends it to the serial port
  String taskStatus = "false";
  if (occupying && doneOccupying) {
    occupying = false;
    taskStatus = "true";
    bookingActive = true;
  }
  if (unoccupying && doneUnoccupying) {
    unoccupying = false;
    taskStatus = "true";
    bookingActive = false;
  }
  Serial.print("update:");
  Serial.println(taskStatus);
}

void checkVehicle() {
  //sensorValue = analogRead(sensorPin);
  sensorValue = senseDistance();
  if (occupying) {
    if (sensorValue < 3) {
      digitalWrite(ledPin, LOW);
      myservo.write(100);
      doneOccupying = true;
    }
  }
  if (unoccupying) {
    if (sensorValue > 80) {
      digitalWrite(ledPin, LOW);
      myservo.write(120);
      doneUnoccupying = true;
    }
  }
}

float senseDistance() {
  // Clears the trigPin
  float duration = 0;
  float distance = 0;
  for(int i = 0; i < 5; i++) {
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);
    // Sets the trigPin on HIGH state for 10 micro seconds
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
    // Reads the echoPin, returns the sound wave travel time in microseconds
    duration = pulseIn(echoPin, HIGH);
    // Calculating the distance
    distance += duration * 0.034 / 2;
  }

  return distance / 5;
}
