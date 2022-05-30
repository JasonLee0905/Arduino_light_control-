// C++ code
//
int temp = 0;
void RGB_LED_C1(int R,int G,int B)
{
  analogWrite(13,R);
  analogWrite(11,G);
  analogWrite(12,B);
}

void RGB_LED_C2(int R,int G,int B)
{
  analogWrite(10,R);
  analogWrite(8,G);
  analogWrite(9,B);
}

void RGB_LED_E(int R,int G,int B)
{
  analogWrite(7,R);
  analogWrite(5,G);
  analogWrite(6,B);
}

void RGB_LED_T(int R,int G,int B)
{
  analogWrite(4,R);
  analogWrite(2,G);
  analogWrite(3,B);
}

void setup()
{
  pinMode(2,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(4,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(6,OUTPUT);
  pinMode(7,OUTPUT);
  pinMode(8,OUTPUT);
  pinMode(9,OUTPUT);
  pinMode(10,OUTPUT);
  pinMode(11,OUTPUT);
  pinMode(12,OUTPUT);
  pinMode(13,OUTPUT);
  
  for(int i = 0 ; i<256;i++)
  {
    RGB_LED_C1(0,i,i);
    delay(10);
  }
  
  for(int i = 256 ; i>0;i--)
  {
    RGB_LED_C1(0,i,i);
    delay(10);
  }
  
  delay(100);
  
  for(int i = 0 ; i<256;i++)
  {
    RGB_LED_C2(0,i,i);
    delay(10);
  }
  
  for(int i = 256 ; i>0;i--)
  {
    RGB_LED_C2(0,i,i);
    delay(10);
  }
  
  delay(100);
  
    for(int i = 0 ; i<256;i++)
  {
    RGB_LED_E(0,i,i);
    delay(10);
  }
  
  for(int i = 256 ; i>0;i--)
  {
    RGB_LED_E(0,i,i);
    delay(10);
  }
  
  delay(100);
  
      for(int i = 0 ; i<256;i++)
  {
    RGB_LED_T(0,i,i);
    delay(10);
  }
  
  for(int i = 256 ; i>0;i--)
  {
    RGB_LED_T(0,i,i);
    delay(10);
  }
  
  delay(100);
  // red go 
  digitalWrite(13,1);
  delay(100);
  digitalWrite(13,0);
  delay(100);
  
  digitalWrite(10,1);
  delay(100);
  digitalWrite(10,0);
  delay(100);
  
  digitalWrite(7,1);
  delay(100);
  digitalWrite(7,0);
  delay(100);

  digitalWrite(4,1);
  delay(100);
  digitalWrite(4,0);
  delay(100);
  // red back
  digitalWrite(4,1);
  delay(100);
  digitalWrite(4,0);
  delay(100);
  
  digitalWrite(7,1);
  delay(100);
  digitalWrite(7,0);
  delay(100);
  
  digitalWrite(10,1);
  delay(100);
  digitalWrite(10,0);
  delay(100);

  digitalWrite(13,1);
  delay(100);
  digitalWrite(13,0);
  delay(100);
  
  // green go 
  digitalWrite(11,1);
  delay(100);
  digitalWrite(11,0);
  delay(100);
  
  digitalWrite(8,1);
  delay(100);
  digitalWrite(8,0);
  delay(100);
  
  digitalWrite(5,1);
  delay(100);
  digitalWrite(5,0);
  delay(100);

  digitalWrite(2,1);
  delay(100);
  digitalWrite(2,0);
  delay(100);
  // green back
  digitalWrite(2,1);
  delay(100);
  digitalWrite(2,0);
  delay(100);
  
  digitalWrite(5,1);
  delay(100);
  digitalWrite(5,0);
  delay(100);
  
  digitalWrite(8,1);
  delay(100);
  digitalWrite(8,0);
  delay(100);

  digitalWrite(11,1);
  delay(100);
  digitalWrite(11,0);
  delay(100);
  
  
    // blue go 
  digitalWrite(12,1);
  delay(100);
  digitalWrite(12,0);
  delay(100);
  
  digitalWrite(9,1);
  delay(100);
  digitalWrite(9,0);
  delay(100);
  
  digitalWrite(6,1);
  delay(100);
  digitalWrite(6,0);
  delay(100);

  digitalWrite(3,1);
  delay(100);
  digitalWrite(3,0);
  delay(100);
  // green back
  digitalWrite(3,1);
  delay(100);
  digitalWrite(3,0);
  delay(100);
  
  digitalWrite(6,1);
  delay(100);
  digitalWrite(6,0);
  delay(100);
  
  digitalWrite(9,1);
  delay(100);
  digitalWrite(9,0);
  delay(100);

  digitalWrite(12,1);
  delay(100);
  digitalWrite(12,0);
  delay(100);
}

void loop()
{
  // random go 
  temp = random(11,14);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;
  
  temp = random(8,11);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;
  
  temp = random(5,8);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;

  temp = random(2,5);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;
  // random back
  temp = random(2,5);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;
  
  temp = random(5,8);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;
  
  temp = random(8,11);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;

  temp = random(11,14);
  digitalWrite(temp,1);
  delay(100);
  digitalWrite(temp,0);
  delay(100);
  temp = 0;
  
  
}
