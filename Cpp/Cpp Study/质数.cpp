#include<iostream> 
#include<cmath> 
using namespace std; 
int main() 
{ 
  int i,n; 
  cout<<"1~100间的素数有："<<endl; 
  for(n=2;n<=100;n++) 
  { 
      for(i=2;i<=sqrt(n);i++) 
          if(n%i==0) break; 
      if(i>sqrt(n)) cout<<n<<" "; 
  } 
  cout<<endl; 
  system("pause"); 
}

