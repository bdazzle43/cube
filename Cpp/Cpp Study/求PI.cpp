//��PI�Ľ���ֵ 
#include <iostream>
using namespace std;
int main()
{
    int n,o=-1;double pi=1,i;
    cout<<"����n����PI=4[1-1/3+1/5-1/7+��+ ((-1)^n)/(2n+1)]\n"<<"n=";
    cin>>n;
    cout<<"�����С�����\n";
    for (i=1;i<=n;i++)
    {
        pi=pi+o*(1/(2*i+1));
        o=o*(-1);
        }
     cout<<"pi="<<pi*4<<endl;
     system("pause");
}
     
     
