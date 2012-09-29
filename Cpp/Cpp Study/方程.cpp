#include<iostream>
#include<cmath>
using namespace std;
int main()
{
    int a,b,c;double x1,x2,d;char jixu;
    aaa:
        cout<<"求ax^2+bx+c=0,请先输入abc\n";
        bbb:
            cout<<"a=";cin>>a;if (a==0) {cout<<"错误！a应不等于0\n";goto bbb;}
        cout<<"b=";cin>>b;
        cout<<"c=";cin>>c;
        d=b*b-4*a*c;
        if (d<0) cout<<"无解\n";
        if (d==0) cout<<"x1=x2="<<(-b+sqrt(d))/(2*a)<<endl;
        if (d>0) cout<<"x1="<<(-b+sqrt(d))/(2*a)<<endl<<"x2="<<(-b-sqrt(d))/(2*a)<<endl;
        cout<<"是否继续？（Y/N）";
        cin>>jixu;
        if (jixu=='y')goto aaa;
        exit(0);
        }
        
         
