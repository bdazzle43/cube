#include<iostream>
#include<cmath>
using namespace std;
int main()
{
    int a,b,c;double x1,x2,d;char jixu;
    aaa:
        cout<<"��ax^2+bx+c=0,��������abc\n";
        bbb:
            cout<<"a=";cin>>a;if (a==0) {cout<<"����aӦ������0\n";goto bbb;}
        cout<<"b=";cin>>b;
        cout<<"c=";cin>>c;
        d=b*b-4*a*c;
        if (d<0) cout<<"�޽�\n";
        if (d==0) cout<<"x1=x2="<<(-b+sqrt(d))/(2*a)<<endl;
        if (d>0) cout<<"x1="<<(-b+sqrt(d))/(2*a)<<endl<<"x2="<<(-b-sqrt(d))/(2*a)<<endl;
        cout<<"�Ƿ��������Y/N��";
        cin>>jixu;
        if (jixu=='y')goto aaa;
        exit(0);
        }
        
         
