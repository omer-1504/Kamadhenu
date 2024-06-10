int relay1=D0;
int relay2=D2;
void setup()
{
pinMode(relay1,OUTPUT);
pinMode(relay2,OUTPUT);
}
void loop()
{
relay1();
relay2();
}
void relay1()
{
digitalWrite(relay1,HIGH);
delay(5000);
digitalWrite(relay1,LOW);
delay(5000);
}
void relay2()
{
digitalWrite(relay2,HIGH);
delay(5000);
digitalWrite(relay2,LOW);
delay(5000);
}
